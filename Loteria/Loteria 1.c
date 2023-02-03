#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main ()
{
    time_t seed = 0;
    srand (time(&seed));
    unsigned int menu = 0;
    unsigned int numero = 0;
    unsigned int primera = 0;
    unsigned int segunda = 0;
    unsigned int tercera = 0;

    printf("Loteria Darwil\n");
    do
    {
        printf("0--Salir\n");
        printf("1--Jugar\n");
        printf("Elige menu:\n");
        scanf("%d",&menu);

        if(menu == 1)
        {
            do{
                 printf("Ingresa tu numero:\n");
                scanf("%d", &numero);

            if(numero < 0 || numero > 100)
            {
                printf("El numero debe estar comprendido entre 0 y 100\n");
            }
            }while(!(numero >= 0 && numero <= 100));

            primera = rand() % 100;
            segunda = rand() % 100;
            tercera = rand() % 100;

            if(numero == primera)
            {
                printf("Ganaste en primera\n");
            }
            else if(numero == segunda)
            {
                printf("Ganaste en segunda\n");
            }
            else if(numero == tercera)
            {
                printf("Ganaste en tercera\n");
            }
            else
            {
                printf("\nPerdiste");
            }
            printf("\nPrimera: %d",primera);
            printf("\nSegunda: %d",segunda);
            printf("\nTercera: %d",tercera);
            printf("\n\n");
        }
    }
    while(menu != 0);

    return 0;
}
