/*
 Navicat Premium Data Transfer

 Source Server         : localhost3307
 Source Server Type    : MySQL
 Source Server Version : 80034
 Source Host           : localhost:3307
 Source Schema         : sys_teach

 Target Server Type    : MySQL
 Target Server Version : 80034
 File Encoding         : 65001

 Date: 28/12/2024 13:48:44
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for academicyear
-- ----------------------------
DROP TABLE IF EXISTS `academicyear`;
CREATE TABLE `academicyear`  (
  `Id` int NOT NULL AUTO_INCREMENT,
  `YearName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `StartDate` datetime NOT NULL,
  `EndDate` datetime NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of academicyear
-- ----------------------------
INSERT INTO `academicyear` VALUES (1, '2023-2024学年', '2024-10-30 19:17:59', '2024-10-30 19:18:01');

-- ----------------------------
-- Table structure for class
-- ----------------------------
DROP TABLE IF EXISTS `class`;
CREATE TABLE `class`  (
  `ClassID` int NOT NULL AUTO_INCREMENT,
  `ClassName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `HomeroomTeacherID` int NULL DEFAULT NULL,
  `ClassStatus` enum('激活','停用') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Grade` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ClassID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of class
-- ----------------------------
INSERT INTO `class` VALUES (1, '1班', 1, '激活', '初一');

-- ----------------------------
-- Table structure for course_plans
-- ----------------------------
DROP TABLE IF EXISTS `course_plans`;
CREATE TABLE `course_plans`  (
  `PlanID` int NOT NULL AUTO_INCREMENT,
  `SubjectID` int NOT NULL,
  `ClassId` int NOT NULL,
  `ScheduleID` int NOT NULL,
  `TeacherID` int NOT NULL,
  `DayOfWeek` enum('星期一','星期二','星期三','星期四','星期五','星期六','星期天') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`PlanID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of course_plans
-- ----------------------------
INSERT INTO `course_plans` VALUES (1, 1, 1, 2, 1, '星期一');

-- ----------------------------
-- Table structure for daily_schedule
-- ----------------------------
DROP TABLE IF EXISTS `daily_schedule`;
CREATE TABLE `daily_schedule`  (
  `ScheduleID` int NOT NULL AUTO_INCREMENT,
  `ActivityName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '活动名称',
  `StartTime` time NOT NULL COMMENT '开始时间',
  `EndTime` time NOT NULL COMMENT '结束时间',
  PRIMARY KEY (`ScheduleID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

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
  `DepartmentId` int NOT NULL AUTO_INCREMENT,
  `DepartmentName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Responsibilities` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '职责',
  PRIMARY KEY (`DepartmentId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

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
  `ScoreID` int NOT NULL AUTO_INCREMENT,
  `StudentNumber` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学号',
  `SubjectName` int NOT NULL COMMENT '学科名称',
  `ClassName` int NOT NULL COMMENT '班级名称',
  `TeacherID` int NOT NULL COMMENT '教师编号',
  `Score` decimal(5, 2) NOT NULL COMMENT '分数',
  `EntryDate` datetime NULL DEFAULT CURRENT_TIMESTAMP COMMENT '录入时间',
  `ExamID` int NOT NULL COMMENT '考试ID',
  `Status` int NULL DEFAULT NULL,
  PRIMARY KEY (`ScoreID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of exam_scores
-- ----------------------------
INSERT INTO `exam_scores` VALUES (1, '12', 15, 45, 78, 31.00, '2024-10-29 16:23:41', 1, NULL);

-- ----------------------------
-- Table structure for exams
-- ----------------------------
DROP TABLE IF EXISTS `exams`;
CREATE TABLE `exams`  (
  `ExamID` int NOT NULL AUTO_INCREMENT,
  `ExamName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '考试名称',
  `ExamClass` int NOT NULL COMMENT '考试班级',
  `ExamDate` datetime NOT NULL COMMENT '考试时间',
  `SemeterId` int NOT NULL COMMENT '学期',
  `SubjectId` int NULL DEFAULT NULL COMMENT '考试科目',
  PRIMARY KEY (`ExamID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of exams
-- ----------------------------
INSERT INTO `exams` VALUES (1, '第一次数学考试', 1, '2024-10-30 19:16:36', 1, NULL);

-- ----------------------------
-- Table structure for semesters
-- ----------------------------
DROP TABLE IF EXISTS `semesters`;
CREATE TABLE `semesters`  (
  `SemesterID` int NOT NULL AUTO_INCREMENT,
  `SemesterName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `AcademicYearId` int NOT NULL COMMENT '学年',
  PRIMARY KEY (`SemesterID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of semesters
-- ----------------------------
INSERT INTO `semesters` VALUES (1, '第一学期', '2024-09-01', '2024-12-01', 1, '无', 1);

-- ----------------------------
-- Table structure for students
-- ----------------------------
DROP TABLE IF EXISTS `students`;
CREATE TABLE `students`  (
  `StudentID` int NOT NULL AUTO_INCREMENT COMMENT '学生ID，自增主键',
  `ClassID` int NOT NULL COMMENT '班级ID，假设需要与班级表关联',
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
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of students
-- ----------------------------
INSERT INTO `students` VALUES (1, 1, '史延庆', '男', '2024-10-28', '汉', '131122200210013230', '在读', '2024-10-28', '15017485', '20242012', NULL);

-- ----------------------------
-- Table structure for subject
-- ----------------------------
DROP TABLE IF EXISTS `subject`;
CREATE TABLE `subject`  (
  `SubjectID` int NOT NULL AUTO_INCREMENT,
  `SubjectName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`SubjectID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of subject
-- ----------------------------
INSERT INTO `subject` VALUES (1, '数学', 1);

-- ----------------------------
-- Table structure for teachers
-- ----------------------------
DROP TABLE IF EXISTS `teachers`;
CREATE TABLE `teachers`  (
  `TeacherID` int NOT NULL AUTO_INCREMENT,
  `TeacherCode` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `TeacherName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `EntryYear` int NOT NULL,
  `IsActive` tinyint(1) NOT NULL DEFAULT 1,
  `Position` int NULL DEFAULT NULL COMMENT '职务',
  `DepartmentId` int NULL DEFAULT NULL COMMENT '所在部门',
  PRIMARY KEY (`TeacherID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of teachers
-- ----------------------------
INSERT INTO `teachers` VALUES (1, '20210125', '史延庆', 2024, 1, 1, 1);

-- ----------------------------
-- Table structure for transfers
-- ----------------------------
DROP TABLE IF EXISTS `transfers`;
CREATE TABLE `transfers`  (
  `TransferId` int NOT NULL AUTO_INCREMENT,
  `TeacherId` int NOT NULL COMMENT '教师ID',
  `FromDepartmentId` int NULL DEFAULT NULL COMMENT '原部门ID',
  `ToDepartmentId` int NULL DEFAULT NULL COMMENT '目标部门ID',
  `TransferDate` datetime NOT NULL COMMENT '调动日期',
  `Reason` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '调动原因',
  `NewResponsibilities` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL COMMENT '新职责',
  `OldResponsibilities` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL COMMENT '原职责',
  `TransferType` tinyint NOT NULL COMMENT '调动类型',
  `Status` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '状态',
  `Notes` text CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL COMMENT '备注',
  PRIMARY KEY (`TransferId`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of transfers
-- ----------------------------
INSERT INTO `transfers` VALUES (1, 1, 1, 1, '2024-10-31 16:39:31', '测试', '1', '1', 1, '1', '无');

SET FOREIGN_KEY_CHECKS = 1;
