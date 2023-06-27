-- Inserting records into the Weapon table
INSERT INTO Weapon (weapon_id, weapon_name, weapon_type, damage_perShoot, accuracy, has_scope)
VALUES
(1, 'M4A1', 'Assault Rifle', 35, 0.85, 1),
(2, 'AWP', 'Sniper Rifle', 95, 0.95, 1),
(3, 'Pistol', 'Handgun', 20, 0.75, 0);

-- Inserting records into the Team table
INSERT INTO Team (team_id, team_name, points, persons_count)
VALUES
(1, 'Team A', 100, 5),
(2, 'Team B', 75, 4);

-- Inserting records into the Map table
INSERT INTO Map (map_id, map_name, total_players, map_type)
VALUES
(1, 'Dust II', 10, 'Classic'),
(2, 'Mirage', 8, 'Classic');

-- Inserting records into the Genre table
INSERT INTO Genre (genre_id, genre_name)
VALUES
(1, 'First-person Shooter'),
(2, 'Battle Royale');

-- Inserting records into the Skins table
INSERT INTO Skins (skins_id, weapon_id, skin_name, price)
VALUES
(1, 1, 'Dragon Lore', 29.99),
(2, 2, 'Hyper Beast', 19.99),
(3, 3, 'Crimson Web', 9.99);

-- Inserting records into the Player table
INSERT INTO Player (player_id, player_name, player_lvl, player_rank, team_id, fav_weapon)
VALUES
(1, 'John Doe', 50, 'Master Guardian Elite', 1, 1),
(2, 'Jane Smith', 35, 'Distinguished Master Guardian', 1, 2),
(3, 'Mike Johnson', 42, 'Legendary Eagle', 2, 1);

-- Inserting records into the Game table
INSERT INTO Game (game_id, map_id, genre_id, team_id, duration_minutes)
VALUES
(1, 1, 1, 1, 30),
(2, 2, 2, 2, 45);

-- Inserting records into the Achievements table
	