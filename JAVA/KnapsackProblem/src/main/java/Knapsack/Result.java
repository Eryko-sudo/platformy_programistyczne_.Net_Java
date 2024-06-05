package Knapsack;

import java.util.List;

public class Result {
    private List<Item> items;
    private int totalWeight;
    private int totalValue;

    public Result(List<Item> items, int totalWeight, int totalValue) {
        this.items = items;
        this.totalWeight = totalWeight;
        this.totalValue = totalValue;
    }

    public List<Item> getItems() {
        return items;
    }

    public int getTotalWeight() {
        return totalWeight;
    }

    public int getTotalValue() {
        return totalValue;
    }

    public int getItemCount() {
        return items.size();
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Items in knapsack:\n");
        for (Item item : items) {
            sb.append(item.toString()).append("\n");
        }
        sb.append("Total weight: ").append(totalWeight).append("\n");
        sb.append("Total value: ").append(totalValue).append("\n");
        sb.append("Count of items: ").append(getItemCount()).append("\n");
        return sb.toString();
    }
}