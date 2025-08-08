-- Insert Departments
INSERT INTO Depatrations (Name)
VALUES 
('Computer Science'),
('Mathematics'),
('Physics');

-- Insert Subjects
INSERT INTO subjects (Title)
VALUES 
('Algorithms'),
('Calculus'),
('Quantum Mechanics'),
('Databases'),
('Linear Algebra');

-- Insert DepartmentSubjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId)
VALUES
(1, 1), -- Computer Science - Algorithms
(1, 4), -- Computer Science - Databases
(2, 2), -- Mathematics - Calculus
(2, 5), -- Mathematics - Linear Algebra
(3, 3); -- Physics - Quantum Mechanics

-- Insert Students
INSERT INTO Students (name, age, department_id)
VALUES
('Alice', 20, 1),
('Bob', 22, 2),
('Charlie', 21, 1),
('Diana', 23, 3);

-- Insert StudentSubjects
INSERT INTO StudentSubjects (StudentId, SubjectId)
VALUES
(1, 1), -- Alice enrolled in Algorithms
(1, 4), -- Alice enrolled in Databases
(2, 2), -- Bob enrolled in Calculus
(2, 5), -- Bob enrolled in Linear Algebra
(3, 1), -- Charlie enrolled in Algorithms
(3, 4), -- Charlie enrolled in Databases
(4, 3); -- Diana enrolled in Quantum Mechanics
