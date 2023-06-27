SELECT skin_name, price FROM Skins;

SELECT map_name as 'Map', total_players as 'Players' FROM Map WHERE map_type = 'Classic' AND total_players > 8;

SELECT player_name as 'Player', player_rank as 'Rank' FROM Player WHERE player_rank = 'Legendary Eagle';

SELECT Game.game_id, Map.map_name, Genre.genre_name
FROM Game
JOIN Map ON Game.map_id = Map.map_id
JOIN Genre ON Game.genre_id = Genre.genre_id;

