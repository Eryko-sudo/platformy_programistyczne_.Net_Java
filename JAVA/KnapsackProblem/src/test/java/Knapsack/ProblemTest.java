package Knapsack;

import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class ProblemTest {

    @Test
    void testItemFitsInKnapsack() {
        Problem problem = new Problem(1, 1, 1, 10);

        int capacity = 10;

        Result result = problem.solve(capacity);

        assertTrue(result.getTotalWeight() <= capacity);

        assertFalse(result.getItems().isEmpty());
    }

    @Test
    void testNoItemFitsInKnapsack() {
        Problem problem = new Problem(1, 1, 5, 10);

        int capacity = 1;

        Result result = problem.solve(capacity);
        assertTrue(result.getTotalWeight() == 0);
        assertTrue(result.getTotalWeight() <= capacity);
    }

    @Test
    void testItemsFitInKnapsack() {
        Problem problem = new Problem(5, 1, 1, 10);

        int capacity = 15;

        Result result = problem.solve(capacity);

        assertTrue(result.getTotalWeight() <= capacity);
    }

    @Test
    void testProblemInstanceSum() {
        List<Item> items = List.of(
                new Item(0, 1, 10),
                new Item(1, 2, 2),
                new Item(2, 3, 3),
                new Item(3, 4, 4),
                new Item(4, 5, 5)
        );
        Problem problem = new Problem(items);

        int totalWeight = 5;
        int totalValue = 50;

        Result result = problem.solve(5);

        assertTrue(totalWeight == result.getTotalWeight());
        assertTrue(totalValue == result.getTotalValue());
    }
}