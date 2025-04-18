
import java.util.ArrayList;
import java.util.Scanner;

public class Main{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int loop = sc.nextInt();
        sc.nextLine();
        int contador = 1;
        ArrayList<Integer> list = new ArrayList<>();
        for (int i = 0; i < loop; i++) {
            int digito = sc.nextInt();
            sc.nextLine();
            list.add(digito);
        }

        for (int i = 0; i < loop-1; i++) {
            int num = list.get(i);
            if(num != list.get(i+1)){
                contador ++;
            }
        }

        System.out.println(contador);

        sc.close();
    }
}