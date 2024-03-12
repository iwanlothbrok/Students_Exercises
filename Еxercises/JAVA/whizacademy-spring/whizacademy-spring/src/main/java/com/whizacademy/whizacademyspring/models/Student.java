package com.whizacademy.whizacademyspring.models;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

// to become entity in the db


@Entity
@Data // it creates getters, setters, equalt and etc

@AllArgsConstructor // it creates default constructor with all of the props
@NoArgsConstructor //A Lombok annotation that generates a no-argument constructor
@Builder //It provides a convenient way to create instances of the class with a fluent API

// if you want to change the name / same for column
//@Table(name = "dbo.student")
public class Student {
    @Id
    @SequenceGenerator(name = "student_sequence", sequenceName = "student_sequence", allocationSize = 1)
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "student_sequence")

    //@GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    //@Column(columnDefinition = "TEXT")
    //@Column(precision = 10, scale = 2)
    @Column(nullable = false, length = 50)
    private String firstName;

    private String lastName;

    private String email;

    private String phoneNumber;

    private String futureCareer;

    @ManyToOne(fetch = FetchType.LAZY) // Eager: use eager loading when you know that you will always need the associated data
                                        // Lazy: not getting the associated data
    @JoinColumn(name = "mentor_id")
    private Mentor mentor;
}

// CTRL - ALT - L