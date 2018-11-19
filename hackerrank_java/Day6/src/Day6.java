import java.util.Scanner;

public class Day6 {

    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        int T = scanner.nextInt();
        String s;
        for (int i=0 ; i<T ; i++){
            s = scanner.next();
            for (int j=0; j<s.length() ; j++){
                if (j%2==0){
                    System.out.print(s.charAt(j));

                }
            }
            System.out.print(" ");
            for (int j=0; j<s.length() ; j++){
                if (j%2==1){
                    System.out.print(s.charAt(j));

                }
            }
            System.out.println();
        }


    }
}
