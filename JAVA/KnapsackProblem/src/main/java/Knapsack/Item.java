package Knapsack;

public class Item implements Comparable<Item> {
    private int id;
    private int weight;
    private int value;
    private double ratio;

    public Item(int id, int weight, int value) {
        this.id = id;
        this.weight = weight;
        this.value = value;
        this.ratio = (double) value / weight;
    }

    public int getId() {
        return id;
    }

    public int getWeight() {
        return weight;
    }

    public int getValue() {
        return value;
    }

    @Override
    public int compareTo(Item other) {
        return Double.compare(other.ratio, this.ratio);
    }

    @Override
    public String toString() {
        return "Item{" +
                "id=" + id +
                ", weight=" + weight +
                ", value=" + value +
                '}';
    }
}