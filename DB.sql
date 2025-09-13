-- -----------------------------------------------------
-- Database: Education System
-- -----------------------------------------------------
-- Drop database if exists (optional)
-- DROP DATABASE IF EXISTS education_system;
-- CREATE DATABASE education_system;
-- USE education_system;

-- -----------------------------------------------------
-- Table: Student
-- -----------------------------------------------------
CREATE TABLE Student (
    std_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL
);

-- -----------------------------------------------------
-- Table: Payment
-- -----------------------------------------------------
CREATE TABLE Payment (
    payment_id INT PRIMARY KEY AUTO_INCREMENT,
    paid BOOLEAN NOT NULL,
    paying_method VARCHAR(50),
    transition_id VARCHAR(100),
    date DATE NOT NULL,
    std_id INT,
    total_amount DECIMAL(10, 2) NOT NULL,

    FOREIGN KEY (std_id) REFERENCES Student(std_id)
);

-- -----------------------------------------------------
-- Table: Level
-- -----------------------------------------------------
CREATE TABLE Level (
    level_id INT PRIMARY KEY AUTO_INCREMENT,
    level_name VARCHAR(50) NOT NULL,
    level_order INT,
    level_lock BOOLEAN DEFAULT FALSE
);

-- -----------------------------------------------------
-- Table: Quiz
-- -----------------------------------------------------
CREATE TABLE Quiz (
    quiz_id INT PRIMARY KEY AUTO_INCREMENT,
    quiz_name VARCHAR(100) NOT NULL
);

-- -----------------------------------------------------
-- Table: Question
-- -----------------------------------------------------
CREATE TABLE Question (
    ques_id INT PRIMARY KEY AUTO_INCREMENT,
    text TEXT NOT NULL,
    quiz_id INT,

    FOREIGN KEY (quiz_id) REFERENCES Quiz(quiz_id)
);

-- -----------------------------------------------------
-- Table: Choice
-- -----------------------------------------------------
CREATE TABLE Choice (
    choice_id INT PRIMARY KEY AUTO_INCREMENT,
    text TEXT NOT NULL,
    is_true BOOLEAN DEFAULT FALSE,
    ques_id INT,

    FOREIGN KEY (ques_id) REFERENCES Question(ques_id)
);

-- -----------------------------------------------------
-- Table: Examination
-- -----------------------------------------------------
CREATE TABLE Examination (
    trans_id INT PRIMARY KEY AUTO_INCREMENT,
    student_id INT,
    quiz_id INT,
    final_mark DECIMAL(5, 2),
    start_time DATETIME,
    end_time DATETIME,
    level_id INT,

    FOREIGN KEY (student_id) REFERENCES Student(std_id),
    FOREIGN KEY (quiz_id) REFERENCES Quiz(quiz_id),
    FOREIGN KEY (level_id) REFERENCES Level(level_id)
);

-- -----------------------------------------------------
-- End of File
-- -----------------------------------------------------
-- You can now import this file into MySQL using:
-- mysql -u username -p database_name < schema.sql