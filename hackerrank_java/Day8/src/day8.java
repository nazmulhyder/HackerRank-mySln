import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class day8 {
    public static void main(String[] args){
        HashMap<String,Integer> phoneBook = new HashMap<String,Integer>();
        Scanner scanner =  new Scanner(System.in);
        int n = scanner.nextInt();

        for (int i=0 ; i<n ; i++){
            String name = scanner.next();
            int number =  scanner.nextInt();

            phoneBook.put(name,number);

        }

        while (scanner.hasNext()){
            String name = scanner.next();
            if (phoneBook.containsKey(name)){
                System.out.println(name+"="+phoneBook.get(name));
            }
            else {
                System.out.println("not  found");
            }
        }
        scanner.close();
    }
}
