package org.example.library.controller;

import org.example.library.model.User;
import org.example.library.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/user")
public class UserController{

    @Autowired
    private UserRepository userRepository;
    @GetMapping("/getAll")
    public List<User> getAllCategories() {
        return userRepository.findAll();
    }
}
