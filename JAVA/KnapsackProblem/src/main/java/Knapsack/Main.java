package Knapsack;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter the number of item types:");
        int numberOfItemTypes = scanner.nextInt();

        System.out.println("Enter the seed:");
        int seed = scanner.nextInt();

        System.out.println("Enter the lower bound:");
        int lowerBound = scanner.nextInt();

        System.out.println("Enter the upper bound:");
        int upperBound = scanner.nextInt();

        System.out.println("Enter the capacity of the knapsack:");
        int capacity = scanner.nextInt();

        Problem problem = new Problem(numberOfItemTypes, seed, lowerBound, upperBound);

        System.out.println(problem.toString());
        Result result = problem.solve(capacity);

        System.out.println(result.toString());

        scanner.close();
    }
}