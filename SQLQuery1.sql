
INSERT INTO [Training] ([trainingId], [fk_AspNetUser_ID], [week], [frequency], [Intensity], [tonnage], [reps], [avIntensity]) VALUES (1, 'bd18411b-f1fb-4ad7-8a36-ff74385028c8', 4, '4', 8, NULL, NULL, NULL);

COMMIT;


-- -----------------------------------------------------
-- Data for table `[dao]`.`exercise_category`
-- -----------------------------------------------------
INSERT INTO Exercise_category ([exercise_categoryID], [categoryName], [categoryType]) VALUES ('sq', 'Squat', 'Main');
INSERT INTO Exercise_category ([exercise_categoryID], [categoryName], [categoryType]) VALUES ('sqa', 'Squat', 'Assistance');
INSERT INTO Exercise_category ([exercise_categoryID], [categoryName], [categoryType]) VALUES ('bc', 'Press', 'Main');
INSERT INTO Exercise_category ([exercise_categoryID], [categoryName], [categoryType]) VALUES ('bca', 'Press', 'Assistance');
INSERT INTO Exercise_category ([exercise_categoryID], [categoryName], [categoryType]) VALUES ('dl', 'Deadlift', 'Main');
INSERT INTO Exercise_category ([exercise_categoryID], [categoryName], [categoryType]) VALUES ('dla', 'Deadlift', 'Assistance');

COMMIT;


-- -----------------------------------------------------
-- Data for table `[dao]`.`exercise`
-- -----------------------------------------------------
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (1, 'Squat', NULL, NULL, 'sq');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (2, '2 Second Pause Squat', NULL, NULL, 'sqa');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (3, 'Pin Squat', NULL, NULL, 'sqa');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (4, 'Tempo Squat', NULL, NULL, 'sqa');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (5, 'Banded Squat', NULL, NULL, 'sqa');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (6, 'SSB Squat', NULL, NULL, 'sqa');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (7, 'Banded Squat', NULL, NULL, 'sqa');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (8, 'Front Squat', NULL, NULL, 'sqa');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (9, 'Benchpress', NULL, NULL, 'bc');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (10, '1 Second Pause Benchpress', NULL, NULL, 'bc');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (11, '2 Second pause Benchpress', NULL, NULL, 'bca');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (12, '3 Second Pause benchpress', NULL, NULL, 'bca');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (13, 'Pin Benchpress', NULL, NULL, 'bca');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (14, 'Tempo Benchpress', NULL, NULL, 'bca');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (15, 'Bended Benchpress', NULL, NULL, 'bca');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (16, 'SS Benchpress', NULL, NULL, 'bca');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (17, 'Banded Benchpress', NULL, NULL, 'bca');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (18, 'Deadlift', NULL, NULL, 'dl');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (19, '1 Second Pause Deadlift', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (20, '2 Second Pause Deadlift', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (21, 'Deficit Deadlift', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (22, 'Rack/Block Pull', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (23, 'RDL', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (24, 'Snachgrip Deadlift', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (25, 'Banded Deadlift', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (26, 'Trapbar Deadlift', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (27, 'Stiflag Deadlift', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (28, 'Pandlay row', NULL, NULL, 'dla');
INSERT INTO Exercise ([exerciseID], [exerciseName], [1RM], [fk_training_trainingID], [fk_exercise_categoryID]) VALUES (29, 'Goodmorning', NULL, NULL, 'dla');

COMMIT;


-- -----------------------------------------------------
-- Data for table `[dao]`.`bodypart`
-- -----------------------------------------------------
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (1, 'Trap', 0, 0, 12, 26);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (2, 'Pectoralis', 8, 10, 12, 26);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (3, 'Front Delt', 0, 0, 6, 12);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (4, 'Side Delt', 0, 4, 10, 18);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (5, 'Rear Delt', 0, 6, 16, 26);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (6, 'Bicep', 4, 6, 14, 26);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (7, 'Tricep', 0, 4, 10, 18);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (8, 'Forarm', 0, 0, 6, 12);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (9, 'Ab', 0, 0, 16, 25);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (10, 'Oblique', 0, 0, 16, 25);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (11, 'back', 8, 10, 14, 25);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (12, 'Quad', 6, 8, 12, 20);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (13, 'Hamstring', 4, 6, 10, 20);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (14, 'Glute', 0, 0, 4, 16);
INSERT INTO Bodypart ([bodypartID], [bodypartName], [MV], [MEV], [MAV], [MRV]) VALUES (15, 'Calve', 6, 8, 12, 20);

COMMIT;


-- -----------------------------------------------------
-- Data for table `[dao]`.`exercise_has_bodypart`
-- -----------------------------------------------------
INSERT INTO exercise_bodypart ([fk_exercise_exerciseID], [fk_bodypart_bodypartID], [EMG]) VALUES (1, 12, 1);
INSERT INTO exercise_bodypart ([fk_exercise_exerciseID], [fk_bodypart_bodypartID], [EMG]) VALUES (1, 14, 1);
INSERT INTO exercise_bodypart ([fk_exercise_exerciseID], [fk_bodypart_bodypartID], [EMG]) VALUES (1, 15, 0.5);

COMMIT;

select* from Exercise;