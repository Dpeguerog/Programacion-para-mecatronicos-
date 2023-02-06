#include <stdio.h>
#include <stdlib.h>

int main ()
{
    char nombre [20];
    int edad = 0;
    int exit;

    do{
    printf("\n Iniciar curso? Press(0)\n Salir del curso? Press(1)");
    scanf("%d", &exit);

    if (exit == 0)
        {
        printf("\nCual es tu nombre?: ");
    scanf("%s", nombre);

    printf("\nEdad:");
    scanf("%d", &edad);

    printf("\nMatrícula: ");
    scanf("%d", &edad);

    printf ("\nBienvenido al curso!!!");
    }
    }while ( exit != 1);
        return 0;
    }

