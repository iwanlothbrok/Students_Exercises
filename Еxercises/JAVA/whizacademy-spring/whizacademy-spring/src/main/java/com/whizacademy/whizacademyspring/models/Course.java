package com.whizacademy.whizacademyspring.models;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity(name = "Course")
@Data
@AllArgsConstructor // it creates default constructor with all of the props
@NoArgsConstructor //A Lombok annotation that generates a no-argument constructor
@Builder //It provides a convenient way to create instances of the class with a fluent API

public class Course {

    @SequenceGenerator(
            name = "course_id_sequence",
            sequenceName = "course_id_sequence",
            allocationSize = 1
    )
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "course_id_sequence")
    @Id
    private  Integer courseId;

    @Column(nullable = false, length = 150)
    private String courseName;

    @ManyToOne
    @JoinColumn(name = "mentor_id", referencedColumnName = "id")
    private Mentor mentor;
}
