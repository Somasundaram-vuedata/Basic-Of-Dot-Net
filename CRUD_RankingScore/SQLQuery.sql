CREATE DATABASE PlayRankDBS;

USE PlayRankDBS;

CREATE TABLE Teams
(
    TeamId INT IDENTITY(1,1) PRIMARY KEY,
    TeamName VARCHAR(50) NOT NULL,
    City VARCHAR(50)
);

CREATE TABLE Players
(
    PlayerId INT IDENTITY(1,1) PRIMARY KEY,
    PlayerName VARCHAR(50) NOT NULL,
    Age INT,
    TeamId INT FOREIGN KEY REFERENCES Teams(TeamId)
);
CREATE TABLE Matches
(
    MatchId INT IDENTITY(1,1) PRIMARY KEY,
    Team1Id INT,
    Team2Id INT,
    MatchDate DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (Team1Id) REFERENCES Teams(TeamId),
    FOREIGN KEY (Team2Id) REFERENCES Teams(TeamId)
);

CREATE TABLE PlayerScores
(
    ScoreId INT IDENTITY(1,1) PRIMARY KEY,
    MatchId INT,
    PlayerId INT,
    Runs INT DEFAULT 0,
    Balls INT DEFAULT 0,
    Fours INT DEFAULT 0,
    Sixes INT DEFAULT 0,
    Wickets INT DEFAULT 0,

    FOREIGN KEY (MatchId) REFERENCES Matches(MatchId),
    FOREIGN KEY (PlayerId) REFERENCES Players(PlayerId)
);
