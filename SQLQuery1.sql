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

