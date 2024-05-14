USE cinemaTKPMOOP;

CREATE TABLE Movie (
    movie_ID NVARCHAR(50) PRIMARY KEY,
    title NVARCHAR(255),
    genre NVARCHAR(100),
    length INT,
    country NVARCHAR(100),
    director NVARCHAR(255),
    releaseTime DATE,
    actor NVARCHAR(MAX),
    plot NVARCHAR(MAX),
    m_status BIT DEFAULT 1
);

CREATE TABLE Room (
    r_ID NVARCHAR(50) PRIMARY KEY,
    r_capacity INT
);

CREATE TABLE ShowSchedule (
    ss_ID NVARCHAR(50) PRIMARY KEY,
    ss_startTime DATETIME,
    ss_endTime DATETIME,
    ss_status BIT DEFAULT 1,
    r_ID NVARCHAR(50),
    movie_ID NVARCHAR(50),
    FOREIGN KEY (r_ID) REFERENCES Room(r_ID),
    FOREIGN KEY (movie_ID) REFERENCES Movie(movie_ID)
);

CREATE TABLE Seat (
    s_ID NVARCHAR(50) PRIMARY KEY,
    r_ID NVARCHAR(50),
    FOREIGN KEY (r_ID) REFERENCES Room(r_ID)
);

CREATE TABLE Payment (
    p_ID NVARCHAR(50) PRIMARY KEY,
    p_totalPay DECIMAL(18, 2),
    p_drinks INT,
    p_seatQuantity INT,
    p_status BIT DEFAULT 1,
    ss_ID NVARCHAR(50),
    FOREIGN KEY (ss_ID) REFERENCES ShowSchedule(ss_ID)
);

CREATE TABLE Booking (
    p_ID NVARCHAR(50),
    s_ID NVARCHAR(50),
    b_status BIT DEFAULT 1,
    PRIMARY KEY (p_ID, s_ID),
    FOREIGN KEY (p_ID) REFERENCES Payment(p_ID),
    FOREIGN KEY (s_ID) REFERENCES Seat(s_ID)
);

-- Chèn dữ liệu mẫu vào bảng Movie
INSERT INTO Movie (movie_ID, title, genre, length, country, director, releaseTime, actor, plot, m_status)
VALUES 
('M_001', N'The Shawshank Redemption', N'Drama', 142, N'USA', N'Frank Darabont', '1994-09-23', N'Tim Robbins, Morgan Freeman', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', 1),
('M_002', N'The Godfather', N'Crime', 175, N'USA', N'Francis Ford Coppola', '1972-03-24', N'Marlon Brando, Al Pacino', N'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', 1),
('M_003', N'The Dark Knight', N'Action', 152, N'USA', N'Christopher Nolan', '2008-07-18', N'Christian Bale, Heath Ledger', N'When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.', 1),
('M_004', N'Pulp Fiction', N'Crime', 154, N'USA', N'Quentin Tarantino', '1994-10-14', N'John Travolta, Uma Thurman', N'The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.', 1),
('M_005', N'Forrest Gump', N'Drama', 142, N'USA', N'Robert Zemeckis', '1994-07-06', N'Tom Hanks, Robin Wright', N'The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75.', 1);

-- Chèn dữ liệu mẫu vào bảng Room
INSERT INTO Room (r_ID, r_capacity)
VALUES 
(N'R_001', 150),
(N'R_002', 200),
(N'R_003', 100),
(N'R_004', 250),
(N'R_005', 300);

-- 150 chỗ ngồi trong phòng R_001
DECLARE @i INT = 1;
WHILE @i <= 150
BEGIN
    INSERT INTO Seat (s_ID, r_ID)
    VALUES (N'S_' + RIGHT('000' + CAST(@i AS NVARCHAR(3)), 3), N'R_001');
    SET @i = @i + 1;
END

INSERT INTO ShowSchedule (ss_ID, ss_startTime, ss_endTime, ss_status, r_ID, movie_ID)
VALUES 
(N'SS_001', '2024-05-15 10:00:00', '2024-05-15 12:22:00', 1, N'R_001', N'M_001'),
(N'SS_002', '2024-05-15 13:00:00', '2024-05-15 15:55:00', 1, N'R_001', N'M_002'),
(N'SS_003', '2024-05-15 16:00:00', '2024-05-15 18:32:00', 1, N'R_001', N'M_003'),
(N'SS_004', '2024-05-15 19:00:00', '2024-05-15 21:34:00', 1, N'R_001', N'M_004'),
(N'SS_005', '2024-05-15 22:00:00', '2024-05-16 00:22:00', 1, N'R_001', N'M_005');




