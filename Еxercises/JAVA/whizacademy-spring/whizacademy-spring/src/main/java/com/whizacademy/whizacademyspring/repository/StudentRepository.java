package com.whizacademy.whizacademyspring.repository;

import com.whizacademy.whizacademyspring.models.Student;
import jakarta.transaction.Transactional;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

@Repository
public interface StudentRepository extends JpaRepository<Student, Integer> {
    public Student findStudentById(Integer id);

    public Student findByMentorFirstName(String mentorName);


    // JPQL
    @Query("select s from Student as s where s.futureCareer = ?1")
    public Student findByCareer(String career);

    // native & param
    @Query(
            value = "SELECT * FROM student WHERE s.future_career = :career",
            nativeQuery = true
    )
    public Student findByCareerNative(@Param("career") String career);

    @Modifying // INSERT, UPDATE, DELETE, or DDL (Data Definition Language) operations.
    @Transactional
    @Query(
            value = "Update student as s set future_career = ?1 WHERE s.id = ?2",
            nativeQuery = true
    )
    int updateStudentCareerById(String career,Integer id);


    public void deleteById(Integer id);

}
