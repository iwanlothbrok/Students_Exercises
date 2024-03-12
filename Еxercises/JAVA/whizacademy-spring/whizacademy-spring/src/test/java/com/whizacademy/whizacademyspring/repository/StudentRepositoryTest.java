package com.whizacademy.whizacademyspring.repository;

import com.whizacademy.whizacademyspring.models.Student;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

@SpringBootTest //for comprehensive integration testing across all layers of your application
//@DataJpaTest // for focused testing of JPA repository functionality
class StudentRepositoryTest {

    @Autowired
    private StudentRepository studentRepository;


    @Test
    public void addStudent() {

        Student student = Student
                .builder()
                .firstName("Georgi")
                .lastName("Petrov")
                .email("jorkata@abv.bg")
                .phoneNumber("0889100828")
                .build();

        studentRepository.save(student);

    }

    @Test
    public void printStudentById() {

        var second = studentRepository.findStudentById(1);

        System.out.println("Student name: " +
                (second == null
                    ? "There is no student with this name"
                    : second.getFirstName()));
    }

    @Test
    public void printStudentByMentorName() {

        var second = studentRepository.findByMentorFirstName("Ivan");

        System.out.println("Student name: " +
                (second == null
                        ? "There is no student with this mentor"
                        : second.getFirstName()));
    }


    @Test
    public void printStudentByCareerNativeasd() {

        var second = studentRepository.findByCareerNative( "Developer");

        System.out.println("Student name: " +
                (second == null
                        ? "There is no student with this mentor"
                        : second.getFirstName()));
    }

    @Test
    public void updateStudentById() {

        var second = studentRepository.updateStudentCareerById( "Mid .NET Developer",1);

        System.out.println("Student name: " +
               (second == 0
                       ? "There is no student with this mentor"
                       : "Successful changes"));
    }

    @Test
    public void deleteByIdTest() {

        int id = 1;
        studentRepository.deleteById(id);

        var foundedStudent = studentRepository.findStudentById(id);

        System.out.println("Student name: " +
                (foundedStudent == null
                        ? "There is no student with this id"
                        : "Successful changes"));
    }
}