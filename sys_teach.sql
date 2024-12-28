/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80012
 Source Host           : localhost:3306
 Source Schema         : sys_teach

 Target Server Type    : MySQL
 Target Server Version : 80012
 File Encoding         : 65001

 Date: 28/12/2024 18:47:44
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for academicyear
-- ----------------------------
DROP TABLE IF EXISTS `academicyear`;
CREATE TABLE `academicyear`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `YearName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of academicyear
-- ----------------------------
INSERT INTO `academicyear` VALUES (1, '2023-2024学年', '2024-10-30 19:17:59', '2024-10-30 19:18:01');

-- ----------------------------
-- Table structure for class
-- ----------------------------
DROP TABLE IF EXISTS `class`;
CREATE TABLE `class`  (
  `ClassID` int(11) NOT NULL AUTO_INCREMENT,
  `ClassName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `HomeroomTeacherID` int(11) NULL DEFAULT NULL,
  `ClassStatus` enum('激活','停用') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Grade` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ClassID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of class
-- ----------------------------
INSERT INTO `class` VALUES (1, '1班', 1, '激活', '初一');

-- ----------------------------
-- Table structure for course_plans
-- ----------------------------
DROP TABLE IF EXISTS `course_plans`;
CREATE TABLE `course_plans`  (
  `PlanID` int(11) NOT NULL AUTO_INCREMENT,
  `SubjectID` int(11) NOT NULL,
  `ClassId` int(11) NOT NULL,
  `ScheduleID` int(11) NOT NULL,
  `TeacherID` int(11) NOT NULL,
  `DayOfWeek` enum('星期一','星期二','星期三','星期四','星期五','星期六','星期天') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`PlanID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of course_plans
-- ----------------------------
INSERT INTO `course_plans` VALUES (1, 1, 1, 2, 1, '星期一');

-- ----------------------------
-- Table structure for daily_schedule
-- ----------------------------
DROP TABLE IF EXISTS `daily_schedule`;
CREATE TABLE `daily_schedule`  (
  `ScheduleID` int(11) NOT NULL AUTO_INCREMENT,
  `ActivityName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '活动名称',
  `StartTime` time NOT NULL COMMENT '开始时间',
  `EndTime` time NOT NULL COMMENT '结束时间',
  PRIMARY KEY (`ScheduleID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of daily_schedule
-- ----------------------------
INSERT INTO `daily_schedule` VALUES (1, '预备', '07:50:00', '08:00:00');
INSERT INTO `daily_schedule` VALUES (2, '第一节课', '08:00:00', '08:45:00');

-- ----------------------------
-- Table structure for departments
-- ----------------------------
DROP TABLE IF EXISTS `departments`;
CREATE TABLE `departments`  (
  `DepartmentId` int(11) NOT NULL AUTO_INCREMENT,
  `DepartmentName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Responsibilities` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '职责',
  PRIMARY KEY (`DepartmentId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of departments
-- ----------------------------
INSERT INTO `departments` VALUES (1, '校长办公室', '');
INSERT INTO `departments` VALUES (2, '教务处', '学校课程管理主要部门');
INSERT INTO `departments` VALUES (3, '学工处', '高校学生管理');
INSERT INTO `departments` VALUES (4, '教师队伍', '学校教育工作承担');
INSERT INTO `departments` VALUES (5, '班主任', '管理指导班级工作');

-- ----------------------------
-- Table structure for exam_scores
-- ----------------------------
DROP TABLE IF EXISTS `exam_scores`;
CREATE TABLE `exam_scores`  (
  `ScoreID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNumber` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学号',
  `SubjectName` int(11) NOT NULL COMMENT '学科名称',
  `ClassName` int(11) NOT NULL COMMENT '班级名称',
  `TeacherID` int(11) NOT NULL COMMENT '教师编号',
  `Score` decimal(5, 2) NOT NULL COMMENT '分数',
  `EntryDate` datetime NULL DEFAULT CURRENT_TIMESTAMP COMMENT '录入时间',
  `ExamID` int(11) NOT NULL COMMENT '考试ID',
  `Status` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`ScoreID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of exam_scores
-- ----------------------------
INSERT INTO `exam_scores` VALUES (1, '12', 15, 45, 78, 31.00, '2024-10-29 16:23:41', 1, NULL);

-- ----------------------------
-- Table structure for exams
-- ----------------------------
DROP TABLE IF EXISTS `exams`;
CREATE TABLE `exams`  (
  `ExamID` int(11) NOT NULL AUTO_INCREMENT,
  `ExamName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '考试名称',
  `ExamClass` int(11) NOT NULL COMMENT '考试班级',
  `ExamDate` datetime NOT NULL COMMENT '考试时间',
  `SemeterId` int(11) NOT NULL COMMENT '学期',
  `SubjectId` int(11) NULL DEFAULT NULL COMMENT '考试科目',
  PRIMARY KEY (`ExamID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of exams
-- ----------------------------
INSERT INTO `exams` VALUES (1, '第一次数学考试', 1, '2024-10-30 19:16:36', 1, NULL);

-- ----------------------------
-- Table structure for positions
-- ----------------------------
DROP TABLE IF EXISTS `positions`;
CREATE TABLE `positions`  (
  `PositionID` int(11) NOT NULL,
  `PositionName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '职务名称',
  PRIMARY KEY (`PositionID`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of positions
-- ----------------------------
INSERT INTO `positions` VALUES (1, '学科教师');
INSERT INTO `positions` VALUES (2, '教务员');
INSERT INTO `positions` VALUES (3, '实验员/实验室管理员');
INSERT INTO `positions` VALUES (4, '校长/副校长');
INSERT INTO `positions` VALUES (5, '教务主任/年级主任');

-- ----------------------------
-- Table structure for semesters
-- ----------------------------
DROP TABLE IF EXISTS `semesters`;
CREATE TABLE `semesters`  (
  `SemesterID` int(11) NOT NULL AUTO_INCREMENT,
  `SemesterName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `AcademicYearId` int(11) NOT NULL COMMENT '学年',
  PRIMARY KEY (`SemesterID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of semesters
-- ----------------------------
INSERT INTO `semesters` VALUES (1, '第一学期', '2024-09-01', '2024-12-01', 1, '无', 1);

-- ----------------------------
-- Table structure for serial_number
-- ----------------------------
DROP TABLE IF EXISTS `serial_number`;
CREATE TABLE `serial_number`  (
  `serial_id` int(11) NOT NULL COMMENT 'id',
  `student_serial` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '学生流水号',
  `teacher_serial` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '教师流水号',
  PRIMARY KEY (`serial_id`) USING BTREE
) ENGINE = MyISAM AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of serial_number
-- ----------------------------
INSERT INTO `serial_number` VALUES (1, '000000001', '12412304');

-- ----------------------------
-- Table structure for students
-- ----------------------------
DROP TABLE IF EXISTS `students`;
CREATE TABLE `students`  (
  `StudentID` int(11) NOT NULL AUTO_INCREMENT COMMENT '学生ID，自增主键',
  `ClassID` int(11) NOT NULL COMMENT '班级ID，假设需要与班级表关联',
  `Name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学生姓名，非空',
  `Gender` enum('男','女') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '性别',
  `BirthDate` date NOT NULL COMMENT '出生日期',
  `Ethnicity` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '民族',
  `IDCardNumber` varchar(18) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '身份证号',
  `EnrollmentStatus` enum('在读','已毕业','休学','退学') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学籍状态',
  `EnrollmentDate` date NOT NULL COMMENT '入学时间',
  `PhoneNumber` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '联系电话',
  `StudentNumber` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学号',
  `Remarks` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL COMMENT '备注字段',
  PRIMARY KEY (`StudentID`) USING BTREE,
  UNIQUE INDEX `IDCardNumber`(`IDCardNumber` ASC) USING BTREE,
  UNIQUE INDEX `StudentNumber`(`StudentNumber` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of students
-- ----------------------------
INSERT INTO `students` VALUES (1, 1, '史延庆', '男', '2024-10-28', '汉', '131122200210013230', '在读', '2024-10-28', '15017485', '20242012', NULL);

-- ----------------------------
-- Table structure for subject
-- ----------------------------
DROP TABLE IF EXISTS `subject`;
CREATE TABLE `subject`  (
  `SubjectID` int(11) NOT NULL AUTO_INCREMENT,
  `SubjectName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`SubjectID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of subject
-- ----------------------------
INSERT INTO `subject` VALUES (1, '数学', 1);

-- ----------------------------
-- Table structure for teachers
-- ----------------------------
DROP TABLE IF EXISTS `teachers`;
CREATE TABLE `teachers`  (
  `TeacherID` int(11) NOT NULL AUTO_INCREMENT,
  `TeacherCode` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `TeacherName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `EntryYear` date NULL DEFAULT NULL,
  `IsActive` tinyint(1) NULL DEFAULT 1,
  `Position` int(11) NULL DEFAULT NULL COMMENT '职务',
  `DepartmentId` int(11) NULL DEFAULT NULL COMMENT '所在部门',
  PRIMARY KEY (`TeacherID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of teachers
-- ----------------------------
INSERT INTO `teachers` VALUES (4, '20211513', '路人甲', '2024-12-28', 1, 1, 1);
INSERT INTO `teachers` VALUES (5, '202412412301', '222222222222222', '2024-12-28', 1, 1, 1);
INSERT INTO `teachers` VALUES (6, '202412412302', '333', '2024-12-28', 1, 1, 1);
INSERT INTO `teachers` VALUES (7, '202412412303', '11111111', '2024-12-28', 1, 1, 1);

-- ----------------------------
-- Table structure for transfers
-- ----------------------------
DROP TABLE IF EXISTS `transfers`;
CREATE TABLE `transfers`  (
  `TransferId` int(11) NOT NULL AUTO_INCREMENT,
  `TeacherId` int(11) NOT NULL COMMENT '教师ID',
  `FromDepartmentId` int(11) NULL DEFAULT NULL COMMENT '原部门ID',
  `ToDepartmentId` int(11) NULL DEFAULT NULL COMMENT '目标部门ID',
  `TransferDate` datetime NOT NULL COMMENT '调动日期',
  `Reason` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '调动原因',
  `NewResponsibilities` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL COMMENT '新职责',
  `OldResponsibilities` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL COMMENT '原职责',
  `TransferType` tinyint(4) NOT NULL COMMENT '调动类型',
  `Status` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '状态',
  `Notes` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL COMMENT '备注',
  PRIMARY KEY (`TransferId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of transfers
-- ----------------------------
INSERT INTO `transfers` VALUES (1, 1, 1, 1, '2024-10-31 16:39:31', '测试', '1', '1', 1, '1', '无');

SET FOREIGN_KEY_CHECKS = 1;
