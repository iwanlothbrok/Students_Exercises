-- Insert statements for the Weapon table
INSERT INTO Weapon (weapon_name, weapon_type, damage_perShoot, accuracy, has_scope)
VALUES ('M4A1', 'Assault Rifle', 50, 0.75, 1);

INSERT INTO Weapon (weapon_name, weapon_type, damage_perShoot, accuracy, has_scope)
VALUES ('AWP', 'Sniper Rifle', 100, 0.95, 1);

INSERT INTO Weapon (weapon_name, weapon_type, damage_perShoot, accuracy, has_scope)
VALUES ('Glock-18', 'Pistol', 25, 0.85, 0);

-- Insert statements for the Team table
INSERT INTO Team (team_name, points, person_count)
VALUES ('Team A', 100, 5);

INSERT INTO Team (team_name, points, person_count)
VALUES ('Team B', 80, 4);

-- Insert statements for the Player table
INSERT INTO Player (player_name, player_lvl, player_experience, player_rank, team_id, fav_weapon)
VALUES ('John Doe', 10, 5000, 'Gold', 1, 1);

INSERT INTO Player (player_name, player_lvl, player_experience, player_rank, team_id, fav_weapon)
VALUES ('Jane Smith', 8, 3800, 'Silver', 1, 3);

-- Insert statements for the Map table
INSERT INTO Map (map_name, players_count, map_size, map_type)
VALUES ('Dust II', 10, 'Medium', 'Deathmatch');

INSERT INTO Map (map_name, players_count, map_size, map_type)
VALUES ('Mirage', 8, 'Small', 'Capture the Flag');


-- Insert statements for the Genre table
INSERT INTO Genre (genre_name)
VALUES ('First-person Shooter');

INSERT INTO Genre (genre_name)
VALUES ('Multiplayer');


-- Insert statements for the Game table
INSERT INTO Game (map_id, genre_id, duration_minutes)
VALUES (1, 1, 30);

INSERT INTO Game (map_id, genre_id, duration_minutes)
VALUES (2, 2, 20);


-- Insert statements for the Skins table
INSERT INTO Skins (weapon_id, skin_name, price)
VALUES (1, 'Dragon Lore', 50.99);

INSERT INTO Skins (weapon_id, skin_name, price)
VALUES (2, 'Asiimov', 30.50);

-- Insert statements for the Achievements table
INSERT INTO Achievments (achievments_name, unlock_date, player_id)
VALUES ('Headshot Master', '2023-06-01 14:30:00', 1);

INSERT INTO Achievments (achievments_name, unlock_date, player_id)
VALUES ('Team Player', '2023-06-02 09:45:00', 2);

-- SECOND INSERT STATEMENT

-- Insert statements for the Weapon table
INSERT INTO Weapon (weapon_name, weapon_type, damage_perShoot, accuracy, has_scope)
VALUES ('AK-47', 'Assault Rifle', 55, 0.80, 1);

INSERT INTO Weapon (weapon_name, weapon_type, damage_perShoot, accuracy, has_scope)
VALUES ('Desert Eagle', 'Pistol', 35, 0.90, 0);

-- Insert statements for the Team table
INSERT INTO Team (team_name, points, person_count)
VALUES ('Team C', 120, 6);

INSERT INTO Team (team_name, points, person_count)
VALUES ('Team D', 95, 5);

-- Insert statements for the Player table
INSERT INTO Player (player_name, player_lvl, player_experience, player_rank, team_id, fav_weapon)
VALUES ('Mark Johnson', 12, 7000, 'Diamond', 2, 2);

INSERT INTO Player (player_name, player_lvl, player_experience, player_rank, team_id, fav_weapon)
VALUES ('Emily Davis', 7, 2500, 'Bronze', 2, 1);

-- Insert statements for the Map table
INSERT INTO Map (map_name, players_count, map_size, map_type)
VALUES ('Nuke', 12, 'Large', 'Bomb Defusal');

INSERT INTO Map (map_name, players_count, map_size, map_type)
VALUES ('Overpass', 10, 'Medium', 'Capture the Flag');

-- Insert statements for the Game table
INSERT INTO Game (map_id, genre_id, duration_minutes)
VALUES (3, 1, 40);

INSERT INTO Game (map_id, genre_id, duration_minutes)
VALUES (4, 2, 25);

-- Insert statements for the Genre table
INSERT INTO Genre (genre_name)
VALUES ('Battle Royale');

INSERT INTO Genre (genre_name)
VALUES ('Strategy');

-- Insert statements for the Skins table
INSERT INTO Skins (weapon_id, skin_name, price)
VALUES (3, 'Fire Serpent', 80.50);

INSERT INTO Skins (weapon_id, skin_name, price)
VALUES (1, 'Hyper Beast', 45.99);

-- Insert statements for the Achievements table
INSERT INTO Achievments (achievments_name, unlock_date, player_id)
VALUES ('Master of All Weapons', '2023-06-05 18:20:00', 3);

INSERT INTO Achievments (achievments_name, unlock_date, player_id)
VALUES ('Flag Capture Pro', '2023-06-07 11:15:00', 4);
