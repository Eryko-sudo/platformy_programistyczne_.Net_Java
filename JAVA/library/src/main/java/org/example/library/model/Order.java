package org.example.library.model;

import jakarta.persistence.*;
import lombok.Getter;

import java.util.Date;

@Entity
@Getter
@Table(name = "`order`")
public class Order {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id_order;
    private Integer id_user;
    private Integer id_book;
    private Date order_date;
    private Date return_by_date;
    private Date return_date;
}
