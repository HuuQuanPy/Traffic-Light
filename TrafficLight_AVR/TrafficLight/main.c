/*
 * TrafficLight.c
 *
 * Created: 29/10/2022 08:23:52 AM
 * Author : ADMIN
 */ 

#define F_CPU 8000000UL
#include <avr/io.h>
#include <util/delay.h>
#include <avr/interrupt.h>
#include <stdio.h>

volatile unsigned long counter_overflow = 0 ;
char mode, index;
char data[] = "000000000" ;
unsigned char timeGreenA, timeGreenB, timeYellowA, timeYellowB;
	
void displayLAMP1(unsigned int x)
{
	PORTA = 16*(x/10) + x%10;
}

void displayLAMP2(unsigned int x)
{
	PORTB = 16*(x/10) + x%10;
}

ISR(TIMER0_OVF_vect)
{
	TCNT0 = 130;
	counter_overflow++;
}

void UART_send(unsigned char dataSend)
{
	while((UCSRA & (1<<UDRE)) == 0x00){};
	UDR = dataSend;
}

unsigned char UART_receive(void)
{
	while((UCSRA & (1<<RXC)) == 0x00){};
	return(UDR);
}

void UART_transmit(int x)
{
	uint16_t temp, ch, dv;
	temp = x;
	dv = (char) (temp % 10) + 48;
	temp = x/10;
	ch = (char) (temp) + 48;
	
	UART_send(ch);
	_delay_ms(1);
	UART_send(dv);
	_delay_ms(1);
}	

int main(void)
{
	int t = 0;
	int TXA = 10 , TVA = 3 , TXB = 10 , TVB = 3 , TDB, T1, T2, T;	
	char light ;
	int act_TimerA , act_TimerB;
	
	DDRA = 0xff;
	PORTA = 0xff;
	
	DDRB = 0xff;
	PORTB = 0xff;
	
	DDRC = (1<<PINC7) | (1<<PINC6) | (1<<PINC1) | (1<<PINC0);
	PORTC = 0xff;
	
	DDRD = (1<<PIND5) | (1<<PIND4) ;
	PORTD = 0xff;
	
	TCCR0 = (1<<CS00) | (1<<CS01);
	TCNT0 = 130;
	TIMSK = (1<<TOIE0);
	
	UBRRL = 0x33;
	UBRRH = 0;
	UCSRA = 0x00;
	UCSRB = (1<<RXEN) | (1<<TXEN) | (1<<RXCIE);
	UCSRC = (1<<URSEL) | (1<<UCSZ1) | (1<<UCSZ0);
	sei();
	
    /* Replace with your application code */
    while (1) 
    {
		TXA = (int) timeGreenA;
		TVA = (int) timeYellowA;
		TXB = (int) timeGreenB;
		TVB = (int) timeYellowB;
		//mode = '1';
		switch (mode)
		{
			// mode 1: normal
			case '1':
			TDB = TXA + TVA;
			T1 = TDB;
			T2 = T1 + TXB ;
			T = T2 + TVB;
			
			if (t < TXA)
			{
				light = 1;
				act_TimerA = TXA - t - 1 ;
				act_TimerB = T1 - t - 1 ;
			}
			else if((t >= TXA) && (t < T1))
			{
				light = 2;
				act_TimerA = T1 - t - 1 ;
				act_TimerB = T1 - t - 1 ;
			}
			else if((t >= T1 ) && (t < T2))
			{
				light = 3;
				act_TimerA = T - t - 1 ;
				act_TimerB = T2 - t - 1 ;
			}
			else if((t >= T2 ) && (t < T ))
			{
				light = 4;
				act_TimerA = T - t - 1 ;
				act_TimerB = T - t - 1 ;
			}
			
			PORTC = ~(((light == 1)<<PINC6) | // ON Lamp Green1
					  ((light == 3)<<PINC7) | // ON Lamp Green2
					 (((light == 1) || (light == 2))<<PINC1) | // ON Lamp Red2
				   	 (((light == 3) || (light == 4))<<PINC0)); // ON Lamp Red1
			
			PORTD = ~(((light == 2)<<PIND4) | // ON Lamp Yellow1
					  ((light == 4)<<PIND5)); // ON Lamp Yellow2
				
			displayLAMP1(act_TimerA);
			displayLAMP2(act_TimerB);
				
			if (counter_overflow == 0)
			{
				UART_send(light+48);
				_delay_ms(1);
				UART_transmit(act_TimerA);
				UART_transmit(act_TimerB);
			}
			if (counter_overflow >= 1000)
			{
				t++;
				counter_overflow = 0;
				if (t >= T) t = 0;
			}
			break;
			// mode 2: night( on/off yellow 1s )
			case '2':
			t = 0;
			PORTA = 0xff;
			PORTB = 0xff;
			PORTC = 0xff;
			
			if (PORTD == 0xcf)
			{
				light = 5;
			}
			else light = 6;
			
			if (counter_overflow == 0)
			{
				UART_send(light+48);
				_delay_ms(1);
			}
			if (counter_overflow >= 1000)
			{
				PORTD ^= 0x30;
				counter_overflow = 0;
			}
			break;
			
			default:
			counter_overflow = 0;
			t = 0;
			PORTA = 0xff;
			PORTB = 0xff;
			PORTC = 0xff;
			PORTD = 0xff;

			break;
		}
    }
}
ISR(USART_RXC_vect)
{
	data[index] = UDR;
	index++;
	if (index > 8)
	{
		mode = data[0];
		timeGreenA = (data[1]-48) * 10 + (data[2]-48);
		timeYellowA =(data[3]-48) * 10 + (data[4]-48);
		timeGreenB = (data[5]-48) * 10 + (data[6]-48);
		timeYellowB =(data[7]-48) * 10 + (data[8]-48);
		index = 0;
	}
}

