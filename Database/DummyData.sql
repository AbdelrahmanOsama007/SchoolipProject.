-- =============================================
-- SchoolipProject Database Dummy Data Script
-- =============================================

-- Clear existing data (if any)
DELETE FROM StudentSubjects;
DELETE FROM DepartmentSubjects;
DELETE FROM Students;
DELETE FROM Subjects;
DELETE FROM Depatrments;

-- Reset identity columns
DBCC CHECKIDENT ('Students', RESEED, 0);
DBCC CHECKIDENT ('Subjects', RESEED, 0);
DBCC CHECKIDENT ('Depatrments', RESEED, 0);
DBCC CHECKIDENT ('DepartmentSubjects', RESEED, 0);
DBCC CHECKIDENT ('StudentSubjects', RESEED, 0);

-- =============================================
-- INSERT DEPARTMENTS
-- =============================================
INSERT INTO Depatrments (Name) VALUES
('Computer Science'),
('Mathematics'),
('Physics'),
('Chemistry'),
('Biology'),
('Engineering'),
('Business Administration'),
('Economics'),
('Literature'),
('History');

-- =============================================
-- INSERT SUBJECTS
-- =============================================
INSERT INTO Subjects (Title) VALUES
-- Computer Science Subjects
('Programming Fundamentals'),
('Data Structures'),
('Algorithms'),
('Database Systems'),
('Web Development'),
('Software Engineering'),
('Computer Networks'),
('Operating Systems'),
('Artificial Intelligence'),
('Machine Learning'),

-- Mathematics Subjects
('Calculus I'),
('Calculus II'),
('Linear Algebra'),
('Discrete Mathematics'),
('Statistics'),
('Probability Theory'),
('Number Theory'),
('Differential Equations'),

-- Physics Subjects
('Mechanics'),
('Thermodynamics'),
('Electromagnetism'),
('Quantum Physics'),
('Optics'),
('Nuclear Physics'),

-- Chemistry Subjects
('General Chemistry'),
('Organic Chemistry'),
('Inorganic Chemistry'),
('Physical Chemistry'),
('Biochemistry'),
('Analytical Chemistry'),

-- Biology Subjects
('Cell Biology'),
('Genetics'),
('Ecology'),
('Microbiology'),
('Anatomy'),
('Physiology'),

-- Engineering Subjects
('Engineering Mechanics'),
('Materials Science'),
('Thermodynamics'),
('Fluid Mechanics'),
('Control Systems'),
('Digital Electronics'),

-- Business Subjects
('Principles of Management'),
('Marketing'),
('Financial Accounting'),
('Business Law'),
('Economics'),
('Human Resources'),

-- Literature Subjects
('English Literature'),
('Creative Writing'),
('Poetry'),
('Drama'),
('Novel Studies'),
('Literary Criticism'),

-- History Subjects
('World History'),
('Ancient History'),
('Medieval History'),
('Modern History'),
('American History'),
('European History');

-- =============================================
-- INSERT STUDENTS
-- =============================================
INSERT INTO Students (name, age, department_id) VALUES
-- Computer Science Students
('Ahmed Hassan', 20, 1),
('Fatima Ali', 19, 1),
('Mohammed Khalil', 21, 1),
('Aisha Rahman', 20, 1),
('Omar Ibrahim', 22, 1),
('Layla Ahmed', 19, 1),
('Youssef Hassan', 21, 1),
('Nour Ali', 20, 1),

-- Mathematics Students
('Sarah Johnson', 20, 2),
('Michael Brown', 21, 2),
('Emily Davis', 19, 2),
('David Wilson', 22, 2),
('Jessica Miller', 20, 2),
('Christopher Garcia', 21, 2),
('Amanda Martinez', 19, 2),
('Daniel Rodriguez', 20, 2),

-- Physics Students
('Robert Taylor', 21, 3),
('Jennifer Anderson', 20, 3),
('Thomas Jackson', 22, 3),
('Lisa White', 19, 3),
('Kevin Harris', 21, 3),
('Nicole Martin', 20, 3),
('Steven Thompson', 19, 3),
('Rachel Moore', 22, 3),

-- Chemistry Students
('Andrew Lee', 20, 4),
('Stephanie Clark', 21, 4),
('Ryan Lewis', 19, 4),
('Michelle Hall', 22, 4),
('Brandon Young', 20, 4),
('Amber King', 21, 4),
('Tyler Wright', 19, 4),
('Brittany Green', 20, 4),

-- Biology Students
('Cody Baker', 21, 5),
('Heather Adams', 20, 5),
('Travis Nelson', 22, 5),
('Melissa Carter', 19, 5),
('Derek Mitchell', 21, 5),
('Tiffany Perez', 20, 5),
('Corey Roberts', 19, 5),
('Crystal Turner', 22, 5),

-- Engineering Students
('Jordan Phillips', 20, 6),
('Vanessa Campbell', 21, 6),
('Blake Parker', 19, 6),
('Chelsea Evans', 22, 6),
('Tanner Edwards', 20, 6),
('Megan Collins', 21, 6),
('Garrett Stewart', 19, 6),
('Brooke Morris', 20, 6),

-- Business Administration Students
('Dillon Rogers', 21, 7),
('Paige Reed', 20, 7),
('Spencer Cook', 22, 7),
('Morgan Bailey', 19, 7),
('Carson Bell', 21, 7),
('Quinn Murphy', 20, 7),
('Riley Richardson', 19, 7),
('Avery Cox', 22, 7),

-- Economics Students
('Parker Howard', 20, 8),
('Reese Ward', 21, 8),
('Sawyer Torres', 19, 8),
('Peyton Peterson', 22, 8),
('Dakota Gray', 20, 8),
('Riley Ramirez', 21, 8),
('Casey James', 19, 8),
('Quinn Watson', 20, 8),

-- Literature Students
('Taylor Brooks', 21, 9),
('Jordan Kelly', 20, 9),
('Morgan Sanders', 22, 9),
('Avery Price', 19, 9),
('Riley Bennett', 21, 9),
('Quinn Wood', 20, 9),
('Casey Barnes', 19, 9),
('Dakota Ross', 22, 9),

-- History Students
('Parker Henderson', 20, 10),
('Reese Coleman', 21, 10),
('Sawyer Jenkins', 19, 10),
('Peyton Perry', 22, 10),
('Dakota Powell', 20, 10),
('Riley Long', 21, 10),
('Casey Patterson', 19, 10),
('Quinn Hughes', 20, 10);

-- =============================================
-- INSERT DEPARTMENT SUBJECTS (Which subjects belong to which departments)
-- =============================================

-- Computer Science Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(1, 1), -- Programming Fundamentals
(1, 2), -- Data Structures
(1, 3), -- Algorithms
(1, 4), -- Database Systems
(1, 5), -- Web Development
(1, 6), -- Software Engineering
(1, 7), -- Computer Networks
(1, 8), -- Operating Systems
(1, 9), -- Artificial Intelligence
(1, 10), -- Machine Learning

-- Mathematics Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(2, 11), -- Calculus I
(2, 12), -- Calculus II
(2, 13), -- Linear Algebra
(2, 14), -- Discrete Mathematics
(2, 15), -- Statistics
(2, 16), -- Probability Theory
(2, 17), -- Number Theory
(2, 18), -- Differential Equations

-- Physics Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(3, 19), -- Mechanics
(3, 20), -- Thermodynamics
(3, 21), -- Electromagnetism
(3, 22), -- Quantum Physics
(3, 23), -- Optics
(3, 24), -- Nuclear Physics

-- Chemistry Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(4, 25), -- General Chemistry
(4, 26), -- Organic Chemistry
(4, 27), -- Inorganic Chemistry
(4, 28), -- Physical Chemistry
(4, 29), -- Biochemistry
(4, 30), -- Analytical Chemistry

-- Biology Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(5, 31), -- Cell Biology
(5, 32), -- Genetics
(5, 33), -- Ecology
(5, 34), -- Microbiology
(5, 35), -- Anatomy
(5, 36), -- Physiology

-- Engineering Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(6, 37), -- Engineering Mechanics
(6, 38), -- Materials Science
(6, 39), -- Thermodynamics
(6, 40), -- Fluid Mechanics
(6, 41), -- Control Systems
(6, 42), -- Digital Electronics

-- Business Administration Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(7, 43), -- Principles of Management
(7, 44), -- Marketing
(7, 45), -- Financial Accounting
(7, 46), -- Business Law
(7, 47), -- Economics
(7, 48), -- Human Resources

-- Economics Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(8, 47), -- Economics (shared with Business)
(8, 15), -- Statistics (shared with Mathematics)
(8, 16), -- Probability Theory (shared with Mathematics)

-- Literature Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(9, 49), -- English Literature
(9, 50), -- Creative Writing
(9, 51), -- Poetry
(9, 52), -- Drama
(9, 53), -- Novel Studies
(9, 54), -- Literary Criticism

-- History Department Subjects
INSERT INTO DepartmentSubjects (DepartmentId, SubjectId) VALUES
(10, 55), -- World History
(10, 56), -- Ancient History
(10, 57), -- Medieval History
(10, 58), -- Modern History
(10, 59), -- American History
(10, 60), -- European History

-- =============================================
-- INSERT STUDENT SUBJECTS (Student enrollments)
-- =============================================

-- Computer Science Students enrollments
INSERT INTO StudentSubjects (StudentId, SubjectId) VALUES
-- Ahmed Hassan (Student ID: 1) - Computer Science
(1, 1), (1, 2), (1, 3), (1, 4), (1, 5),

-- Fatima Ali (Student ID: 2) - Computer Science
(2, 1), (2, 2), (2, 6), (2, 7), (2, 8),

-- Mohammed Khalil (Student ID: 3) - Computer Science
(3, 1), (3, 2), (3, 3), (3, 9), (3, 10),

-- Aisha Rahman (Student ID: 4) - Computer Science
(4, 1), (4, 4), (4, 5), (4, 6), (4, 7),

-- Omar Ibrahim (Student ID: 5) - Computer Science
(5, 2), (5, 3), (5, 4), (5, 8), (5, 9),

-- Layla Ahmed (Student ID: 6) - Computer Science
(6, 1), (6, 2), (6, 5), (6, 6), (6, 10),

-- Youssef Hassan (Student ID: 7) - Computer Science
(7, 3), (7, 4), (7, 7), (7, 8), (7, 9),

-- Nour Ali (Student ID: 8) - Computer Science
(8, 1), (8, 3), (8, 5), (8, 6), (8, 10),

-- Mathematics Students enrollments
INSERT INTO StudentSubjects (StudentId, SubjectId) VALUES
-- Sarah Johnson (Student ID: 9) - Mathematics
(9, 11), (9, 12), (9, 13), (9, 14), (9, 15),

-- Michael Brown (Student ID: 10) - Mathematics
(10, 11), (10, 12), (10, 16), (10, 17), (10, 18),

-- Emily Davis (Student ID: 11) - Mathematics
(11, 12), (11, 13), (11, 14), (11, 15), (11, 16),

-- David Wilson (Student ID: 12) - Mathematics
(12, 11), (12, 13), (12, 15), (12, 17), (12, 18),

-- Jessica Miller (Student ID: 13) - Mathematics
(13, 12), (13, 14), (13, 15), (13, 16), (13, 17),

-- Christopher Garcia (Student ID: 14) - Mathematics
(14, 11), (14, 12), (14, 13), (14, 16), (14, 18),

-- Amanda Martinez (Student ID: 15) - Mathematics
(15, 12), (15, 14), (15, 15), (15, 17), (15, 18),

-- Daniel Rodriguez (Student ID: 16) - Mathematics
(16, 11), (16, 13), (16, 14), (16, 15), (16, 16),

-- Physics Students enrollments
INSERT INTO StudentSubjects (StudentId, SubjectId) VALUES
-- Robert Taylor (Student ID: 17) - Physics
(17, 19), (17, 20), (17, 21), (17, 22), (17, 23),

-- Jennifer Anderson (Student ID: 18) - Physics
(18, 19), (18, 20), (18, 21), (18, 23), (18, 24),

-- Thomas Jackson (Student ID: 19) - Physics
(19, 20), (19, 21), (19, 22), (19, 23), (19, 24),

-- Lisa White (Student ID: 20) - Physics
(20, 19), (20, 21), (20, 22), (20, 23), (20, 24),

-- Kevin Harris (Student ID: 21) - Physics
(21, 19), (21, 20), (21, 22), (21, 23), (21, 24),

-- Nicole Martin (Student ID: 22) - Physics
(22, 20), (22, 21), (22, 22), (22, 23), (22, 24),

-- Steven Thompson (Student ID: 23) - Physics
(23, 19), (23, 20), (23, 21), (23, 22), (23, 24),

-- Rachel Moore (Student ID: 24) - Physics
(24, 19), (24, 21), (24, 22), (24, 23), (24, 24),

-- Chemistry Students enrollments
INSERT INTO StudentSubjects (StudentId, SubjectId) VALUES
-- Andrew Lee (Student ID: 25) - Chemistry
(25, 25), (25, 26), (25, 27), (25, 28), (25, 29),

-- Stephanie Clark (Student ID: 26) - Chemistry
(26, 25), (26, 26), (26, 27), (26, 28), (26, 30),

-- Ryan Lewis (Student ID: 27) - Chemistry
(27, 26), (27, 27), (27, 28), (27, 29), (27, 30),

-- Michelle Hall (Student ID: 28) - Chemistry
(28, 25), (28, 26), (28, 27), (28, 29), (28, 30),

-- Brandon Young (Student ID: 29) - Chemistry
(29, 25), (29, 26), (29, 28), (29, 29), (29, 30),

-- Amber King (Student ID: 30) - Chemistry
(30, 26), (30, 27), (30, 28), (30, 29), (30, 30),

-- Tyler Wright (Student ID: 31) - Chemistry
(31, 25), (31, 26), (31, 27), (31, 28), (31, 30),

-- Brittany Green (Student ID: 32) - Chemistry
(32, 25), (32, 27), (32, 28), (32, 29), (32, 30),

-- Biology Students enrollments
INSERT INTO StudentSubjects (StudentId, SubjectId) VALUES
-- Cody Baker (Student ID: 33) - Biology
(33, 31), (33, 32), (33, 33), (33, 34), (33, 35),

-- Heather Adams (Student ID: 34) - Biology
(34, 31), (34, 32), (34, 33), (34, 35), (34, 36),

-- Travis Nelson (Student ID: 35) - Biology
(35, 32), (35, 33), (35, 34), (35, 35), (35, 36),

-- Melissa Carter (Student ID: 36) - Biology
(36, 31), (36, 32), (36, 33), (36, 34), (36, 36),

-- Derek Mitchell (Student ID: 37) - Biology
(37, 31), (37, 32), (37, 34), (37, 35), (37, 36),

-- Tiffany Perez (Student ID: 38) - Biology
(38, 32), (38, 33), (38, 34), (38, 35), (38, 36),

-- Corey Roberts (Student ID: 39) - Biology
(39, 31), (39, 32), (39, 33), (39, 34), (39, 36),

-- Crystal Turner (Student ID: 40) - Biology
(40, 31), (40, 33), (40, 34), (40, 35), (40, 36);

-- =============================================
-- VERIFICATION QUERIES
-- =============================================

-- Check total counts
SELECT 'Departments' as TableName, COUNT(*) as Count FROM Depatrments
UNION ALL
SELECT 'Subjects' as TableName, COUNT(*) as Count FROM Subjects
UNION ALL
SELECT 'Students' as TableName, COUNT(*) as Count FROM Students
UNION ALL
SELECT 'DepartmentSubjects' as TableName, COUNT(*) as Count FROM DepartmentSubjects
UNION ALL
SELECT 'StudentSubjects' as TableName, COUNT(*) as Count FROM StudentSubjects;

-- Check students by department
SELECT 
    d.Name as Department,
    COUNT(s.id) as StudentCount
FROM Depatrments d
LEFT JOIN Students s ON d.id = s.department_id
GROUP BY d.id, d.Name
ORDER BY d.id;

-- Check subjects by department
SELECT 
    d.Name as Department,
    COUNT(DISTINCT ds.SubjectId) as SubjectCount
FROM Depatrments d
LEFT JOIN DepartmentSubjects ds ON d.id = ds.DepartmentId
GROUP BY d.id, d.Name
ORDER BY d.id;

-- Check student enrollments
SELECT 
    s.name as StudentName,
    d.Name as Department,
    COUNT(ss.SubjectId) as EnrolledSubjects
FROM Students s
JOIN Depatrments d ON s.department_id = d.id
LEFT JOIN StudentSubjects ss ON s.id = ss.StudentId
GROUP BY s.id, s.name, d.Name
ORDER BY s.id;

PRINT 'Dummy data insertion completed successfully!';
PRINT 'Total Records Inserted:';
PRINT '- 10 Departments';
PRINT '- 60 Subjects';
PRINT '- 80 Students';
PRINT '- 60 Department-Subject relationships';
PRINT '- 400 Student-Subject enrollments';
