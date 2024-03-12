package com.whizacademy.whizacademyspring.models;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@Entity
@Data // it creates getters, setters, equalt and etc

@AllArgsConstructor // it creates default constructor with all of the props
@NoArgsConstructor //A Lombok annotation that generates a no-argument constructor
@Builder //It provides a convenient way to create instances of the class with a fluent API

public class Mentor {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer id;

    @Column(nullable = false, length = 50)
    public String firstName;

    @Column(nullable = false, length = 50)
    public String lastName;

    @Column(nullable = false, length = 50)
    public String career;

    @Column(nullable = false, length = 13)
    public String phoneNumber;

    @OneToMany(mappedBy = "mentor", cascade = CascadeType.ALL)
    private List<Course> courses;
}
