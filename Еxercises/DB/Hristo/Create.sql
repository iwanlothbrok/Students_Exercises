create database games

create table Weapon(
	id int auto_increment primary key,
	weapon_name varchar(50) not null,
	weapon_type varchar(50)  not null,
	damage_perShoot int,
	accuracy decimal(17,2),
	has_scope bit
)

create table Team(
	team_id int auto_increment primary key,
	team_name varchar(50)  not null,
	points int,
	person_count int
)

create table Player(
	id int auto_increment primary key,
	player_name varchar(50) not null,
	player_lvl int,
	player_experience int,
	player_rank varchar(50),
	team_id INT DEFAULT  NULL,
	created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY (team_id) REFERENCES Team(team_id),
    fav_weapon INT DEFAULT  NULL,
	FOREIGN KEY (fav_weapon) REFERENCES Weapon(id)
)

create table Map(
	map_id int auto_increment primary key,
	map_name varchar(50) not null,
	players_count int,
	map_size varchar(50),
    map_type varchar(50)
)

create table Game(
	game_id int auto_increment primary key,
	map_id int,
    genre_id int,
	started_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    duration_minutes int,
	FOREIGN KEY (map_id) REFERENCES Map(map_id),
	FOREIGN KEY (genre_id) REFERENCES Genre(genre_id)
)

create table Genre(
	genre_id int auto_increment primary key,
	genre_name varchar(50) not null
)

create table Skins(
	skins_id int auto_increment primary key,
    weapon_id int,
    skin_name varchar(50),
    price decimal(17,2),
	FOREIGN KEY (weapon_id) REFERENCES Weapon(id)
)

create table Achievments(
	achievments_id int auto_increment primary key,
    achievments_name varchar(50),
    unlock_date DATETIME,
    player_id int,
    FOREIGN KEY (player_id) REFERENCES Player(id)
 )


