#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>
#include <windows.h>

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    double m, n, x, a, b;
    double z1, z2, y;

    printf("¬вед≥ть a: ");
    scanf("%lf", &a);
    printf("¬вед≥ть b: ");
    scanf("%lf", &b);
    printf("¬вед≥ть m: ");
    scanf("%lf", &m);
    printf("¬вед≥ть n: ");
    scanf("%lf", &n);
    printf("¬вед≥ть x: ");
    scanf("%lf", &x);

    z1 = ((m - 1) * sqrt(m) - (n - 1) * sqrt(n)) /
        (sqrt(pow(m, 3) * n) + n * m + pow(m, 2) - m);

    z2 = (sqrt(m) - sqrt(n)) / m;

    y = 2.4 * fabs((pow(x, 2) + b) / a)
        + (a - b) * pow(sin(a - b), 2)
        + pow(10.0, -2.0) * (x - b);

    printf("\n–езультати:\n");
    printf("z1 = %.6lf\n", z1);
    printf("z2 = %.6lf\n", z2);
    printf("y  = %.6lf\n", y);

    return 0;
}
