package Knapsack;

public class Main {
    public static void main(String[] args) {
        System.out.print("Wake the f*** Up Samurai, we have a city to burn!\n");

        Problem problem = new Problem(5, 1, 1, 10);

        System.out.println(problem.toString());

        Result result = problem.solve(10);

        System.out.println(result.toString());
    }
}