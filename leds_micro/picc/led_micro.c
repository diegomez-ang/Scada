#include <16F877A.h>
#fuses HS, NOWDT, NOPROTECT, NOWRT, NOBROWNOUT, NOLVP
#use delay (clock = 4000000)
#use rs232(baud=9600, xmit=PIN_C6, rcv=PIN_C7)
#include <stdlib.h>
#include <input.c>
#include <input.c>
#include <string.h>
#byte trisb = 0x86
#byte portb = 0x06
#byte port_d=8

int tiempo= 1000;
//int tiempo2=100;
char caracter;
int c;

void RDA_isr(void){
   gets(c);
  //caracter = getch();
  // gets(caracter);
}


void secuencia_1()
{
   output_b(0b01010101);
   delay_ms(tiempo);
   output_b(0b10101010);
   delay_ms(tiempo);
}
//------------------------------------
void secuencia_2()
{
   output_b(0b00000000);
   delay_ms(tiempo);
   output_b(0b11111111);
   delay_ms(tiempo);
}

///-------------------------------
void secuencia_3()
{ 
   output_b(0b10000001);
   delay_ms(tiempo);
   output_b(0b11000011);
   delay_ms(tiempo);
   output_b(0b11100111);
   delay_ms(tiempo);
   output_b(0b11111111);
   delay_ms(tiempo);
   output_b(0b11100111);
   delay_ms(tiempo);
   output_b(0b11000011);
   delay_ms(tiempo);
   output_b(0b10000001);
   delay_ms(tiempo);
}
//----------------------------------
void secuencia_4()
{
   output_b(0b10000000);
   delay_ms(tiempo);
   output_b(0b01000000);
   delay_ms(tiempo);
   output_b(0b00100000);
   delay_ms(tiempo);
   output_b(0b00010000);
   delay_ms(tiempo);
   output_b(0b00001000);
   delay_ms(tiempo);
   output_b(0b00000100);
   delay_ms(tiempo);
   output_b(0b00000010);
   delay_ms(tiempo);
   output_b(0b00000001);
   delay_ms(tiempo);
   output_b(0b00000010);
   delay_ms(tiempo);
   output_b(0b00000100);
   delay_ms(tiempo);
   output_b(0b00001000);
   delay_ms(tiempo);
   output_b(0b00010000);
   delay_ms(tiempo);
   output_b(0b00100000);
   delay_ms(tiempo);
   output_b(0b01000000);
   delay_ms(tiempo);
   output_b(0b10000000);
   delay_ms(tiempo);
}
void main()
{
   enable_interrupts(INT_RDA);
   enable_interrupts(GLOBAL);
   bit_clear (trisb,0);
   bit_clear (portb,0);
   
   
   
   while(true)
   {   
      output_high(pin_D6);
      delay_ms(200);
      output_low(pin_D6);
      delay_ms(200);
      
      if(caracter == '1'){   
         output_high(pin_D7);
         printf("presionado 1");
         //RDA_isr();
      }
      if(caracter == '2'){
         output_low(pin_D7);
         printf(
         "presionado 2");
      }
          
     
      /*if(caracter == '3'){
         secuencia_4();
      }
      if(caracter == '4'){
        tiempo = 100;
      }
      if(caracter == '5'){
         tiempo = 500;
      }
      if(caracter == '6'){
         tiempo = 1000;
      }*/
   }

}

