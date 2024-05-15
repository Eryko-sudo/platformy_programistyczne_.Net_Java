package Knapsack;

import java.util.Random;
import java.util.List;
import java.util.ArrayList;
import java.util.Collections;

public class Problem {
    private int numberOfItemTypes;
    private int seed;
    private int lowerBound;
    private int upperBound;
    private List<Item> items;

    public Problem(int numberOfItemTypes, int seed, int lowerBound, int upperBound) {
        this.numberOfItemTypes = numberOfItemTypes;
        this.seed = seed;
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.items = new ArrayList<>();

        Random random = new Random(seed);
        for (int i = 0; i < numberOfItemTypes; i++) {
            int weight = random.nextInt(upperBound - lowerBound) + lowerBound;
            int value = random.nextInt(upperBound - lowerBound) + lowerBound;
            items.add(new Item(i, weight, value));
        }
    }

    public Result solve(int capacity) {
        Collections.sort(items);
        List<Item> selectedItems = new ArrayList<>();
        int totalWeight = 0;
        int totalValue = 0;

        for (Item item : items) {
            if (totalWeight + item.getWeight() <= capacity) {
                selectedItems.add(item);
                totalWeight += item.getWeight();
                totalValue += item.getValue();
            } else {
                break;
            }
        }

        return new Result(selectedItems, totalWeight, totalValue);
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Number of item types: ").append(numberOfItemTypes).append("\n");
        sb.append("Seed: ").append(seed).append("\n");
        sb.append("Lower bound: ").append(lowerBound).append("\n");
        sb.append("Upper bound: ").append(upperBound).append("\n");
        sb.append("Items:\n");
        for (Item item : items) {
            sb.append(item.toString()).append("\n");
        }
        return sb.toString();
    }
}