public class Solution {
    public static void StudentGrade(int marks) {
        if(marks >= 90){
            Console.WriteLine("Grade A");
        }
        else if(marks >= 70){
            Console.WriteLine("Grade B");
        }
        else if(marks >= 50){
            Console.WriteLine("Grade C");
        }
        else if(marks >= 35){
            Console.WriteLine("Grade D");
        }
        else {
            Console.WriteLine("Fail");
        }
    }
}