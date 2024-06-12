package org.example.library.controller;

import org.example.library.model.Order;
import org.example.library.repository.OrderRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/order")
public class OrderController{

    @Autowired
    private OrderRepository orderRepository;
    @GetMapping("/getAll")
    public List<Order> getAllOrders() {
        return orderRepository.findAll();
    }
}
