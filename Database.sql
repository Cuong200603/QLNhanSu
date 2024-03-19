DROP DATABASE QLNHANSU
GO

CREATE DATABASE QLNHANSU
GO

USE QLNHANSU
GO

-- Bảng Phòng Ban
CREATE TABLE Departments (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(100)
);
GO

-- Bảng Chức Vụ
CREATE TABLE JobTitles (
    job_title_id INT PRIMARY KEY,
    title_name VARCHAR(100)
);

-- Bảng Nhân Viên
CREATE TABLE Employees (
    employee_id INT PRIMARY KEY,
    name VARCHAR(50),
    date_of_birth DATE,
    gender VARCHAR(10),
    address VARCHAR(100),
    email VARCHAR(100),
    phone_number VARCHAR(20),
    department_id INT,
    job_title_id INT,
    salary DECIMAL(10, 2),
    FOREIGN KEY (department_id) REFERENCES Departments(department_id),
	FOREIGN KEY (job_title_id) REFERENCES JobTitles (job_title_id)
);
GO

-- Bảng Lương
CREATE TABLE Salaries (
    salary_id INT PRIMARY KEY,
    employee_id INT,
    salary_amount DECIMAL(10, 2),
    start_date DATE,
    end_date DATE,
    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
);
GO

CREATE TABLE Account (
    username VARCHAR(20),
    password NVARCHAR(30)
);