#include <stdio.h>
int main()
{
    int answer;
    printf("Welcome to KBC\n");
    
    printf("Your first question!\n");
    printf("Which language we are studying?\n1.C\t2.C++\t3.Fortran\t4.Java\n");
    scanf("%d",&answer);
    if(answer==1){
        printf("Right answer!\n");
    }
    else{
        printf("Wrong answer. You won 0rs!\n");
        return 0;
    }
    
    
    printf("Your Second question!\n");
    printf("What is the new name of the Hyderabad franchise that would replace Deccan Charges in IPL6 ?\n1.SRH\t2.KKR\t3.MI\t4.RCB\n");
    scanf("%d",&answer);
    if(answer==1){
        printf("Right answer!\n");
    }
else{
printf("Wrong answer. You won 100rs!\n");
        return 0;
    }
    printf("Your Third question!\n");
    printf("In which country we are studying?\n1.India\t2.Pakistan\t3.China\t4.Mongolia\n");
    scanf("%d",&answer);
    if(answer==1){
        printf("Right answer!\n");
    }
    else{
        printf("Wrong answer. You won 500rs!\n");
        return 0;
    }
    printf("Your Fourth question!\n");
    printf(“Which color is in Indian Flag ?\n1.Saffron\t2.Pink\t3.Black\t4.Yellow\n");
    scanf("%d",&answer);
    if(answer==1){
        printf("Right answer!\n");
    }
    else{
        printf("Wrong answer. You won 1000rs!\n");
        return 0;
    }
printf("Your Fifth question!\n");
    printf("In VIBGYOR 'V' stands for?\n1.Violet\t2.Vibrant\t3.Vivid\t4.Nothi\n");
    scanf("%d",&answer);
    if(answer==1){
        printf("Right answer!\n You are winner of 10000rs!\n");
    }
    else{
        printf("Wrong answer. You won 1500rs!\n");
        return 0;
    }


    
    return 0;
}
