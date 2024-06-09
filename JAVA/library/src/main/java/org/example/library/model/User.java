package org.example.library.model;

import jakarta.persistence.*;
import lombok.Getter;

@Entity
@Getter
@Table(name = "user")
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id_user;
    private String login;
    private String password;
    private String name;
    private String surname;
    private String street_name;
    private String city;
    private String phone;
    private String email;
}
