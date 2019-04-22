CREATE TABLE `ambulance_table` (
  `ambulance_id` varchar(4) PRIMARY KEY NOT NULL,
  `station` varchar(30) not null
);


INSERT INTO `ambulance_table` (`ambulance_id`, `station`) VALUES
('A110', 'Redville'),
('A42', 'Bluelane'),
('A7', 'Greenfields');


CREATE TABLE `staff_table` (
  `last_name` varchar(30) NOT NULL,
  `first_name` varchar(60) NOT NULL,
  `officer_id` int(6) PRIMARY KEY NOT NULL,
  `skill_level` varchar(12) NOT NULL,
  `assigned_ambulance` varchar(5) DEFAULT NULL,
  FOREIGN KEY (`assigned_ambulance`) REFERENCES `ambulance_table` (`ambulance_id`)ON UPDATE CASCADE
); 


INSERT INTO `staff_table` (`last_name`, `first_name`, `officer_id`, `skill_level`, `assigned_ambulance`) VALUES
('Green', 'Carol', 130001, 'Advanced', NULL),
('Doe', 'Jane', 131234, 'Intermediate', NULL),
('Shield', 'Jill', 132244, 'Basic', NULL),
('Bobbins', 'Bill', 133535, 'Intermediate', NULL),
('Doe', 'John', 135790, 'Basic', NULL),
('Smith', 'Peter', 135970, 'Basic', NULL);


