package org.example.library.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class LibraryController {

    @GetMapping("/library")
    public String library(Model model) {
        // Add attributes to the model
        // model.addAttribute("attributeName", attributeValue);
        return "library";
    }
}