/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : db_system

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2022-11-16 21:10:33
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `tbl_admin`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_admin`;
CREATE TABLE `tbl_admin` (
  `Username` int(50) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `ContactNo` varchar(50) NOT NULL,
  `ImagePath` varchar(100) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_admin
-- ----------------------------
INSERT INTO `tbl_admin` VALUES ('19100298', 'Jessa Mae Cabillo Nitura', 'password', '(+63) 977-2331-123', '');
INSERT INTO `tbl_admin` VALUES ('19100911', 'Haries Bening', 'password', '(+63) 945-6789-123', '');
INSERT INTO `tbl_admin` VALUES ('19100919', 'Patrick Bilaoen', 'password', '(+63) 995-1785-280', '');
INSERT INTO `tbl_admin` VALUES ('19101202', 'Ariane Mariz R. Dulay', 'password', '(+63) 977-1494-323', '');

-- ----------------------------
-- Table structure for `tbl_book`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_book`;
CREATE TABLE `tbl_book` (
  `BookNumber` varchar(100) NOT NULL,
  `ISBN` varchar(100) NOT NULL,
  `Title` varchar(100) NOT NULL,
  `Author` varchar(100) NOT NULL,
  `DeweyDecimalClassification` varchar(100) NOT NULL,
  `Category` varchar(100) NOT NULL,
  `YearofPublication` varchar(100) NOT NULL,
  `Publisher` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Copyright` varchar(100) NOT NULL,
  `Status` varchar(100) NOT NULL,
  `ImagePath` varchar(100) NOT NULL,
  PRIMARY KEY (`BookNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_book
-- ----------------------------
INSERT INTO `tbl_book` VALUES ('00522001', '978-4-54349-094-2', 'Information Technology', 'Richard Fox', '005 - Computer science, information and general works', 'Textbook', '2015', 'Chapman and Hall/CRC.', '6000 Broken Sound Parkway, NW,(Suite 300)', '2015 Jane Done', 'Available', '');
INSERT INTO `tbl_book` VALUES ('00522002', '978-4-54349-094-2', 'Information Technology', 'Richard Fox', '005 - Computer science, information and general works', 'Textbook', '2015', 'Chapman and Hall/CRC.', '6000 Broken Sound Parkway, NW,(Suite 300)', '2015 Jane Done', 'Available', '');
INSERT INTO `tbl_book` VALUES ('00522003', '978-4-54349-094-2', 'Information Technology', 'Richard Fox', '005 - Computer science, information and general works', 'Textbook', '2015', 'Chapman and Hall/CRC.', '6000 Broken Sound Parkway, NW,(Suite 300)', '2015 Jane Done', 'Borrowed', '');
INSERT INTO `tbl_book` VALUES ('00522004', '978-4-54349-094-2', 'Information Technology', 'Richard Fox', '005 - Computer science, information and general works', 'Textbook', '2015', 'Chapman and Hall/CRC.', '6000 Broken Sound Parkway, NW,(Suite 300)', '2015 Jane Done', 'Available', '');
INSERT INTO `tbl_book` VALUES ('00522005', '978-4-54349-094-2', 'Information Technology', 'Richard Fox', '005 - Computer science, information and general works', 'Textbook', '2015', 'Chapman and Hall/CRC.', '6000 Broken Sound Parkway, NW,(Suite 300)', '2015 Jane Done', 'Available', '');
INSERT INTO `tbl_book` VALUES ('10022001', '978-0-12123-124-0', 'The Philosophy of Psychology', 'George Botterill', '100 - Philisophy and psychology', 'Textbook', '1999', 'ArtPostAsia Inc.', 'A/F The Athenaeum, 160 Leviste St., Makati City', '1999 John Q. Smith', 'Available', '');
INSERT INTO `tbl_book` VALUES ('10022002', '978-0-12123-124-0', 'The Philosophy of Psychology', 'George Botterill', '100 - Philisophy and psychology', 'Textbook', '1999', 'ArtPostAsia Inc.', 'A/F The Athenaeum, 160 Leviste St., Makati City', '1999 John Q. Smith', 'Available', '');
INSERT INTO `tbl_book` VALUES ('10022003', '978-0-12123-124-0', 'The Philosophy of Psychology', 'George Botterill', '100 - Philisophy and psychology', 'Textbook', '1999', 'ArtPostAsia Inc.', 'A/F The Athenaeum, 160 Leviste St., Makati City', '1999 John Q. Smith', 'Available', '');
INSERT INTO `tbl_book` VALUES ('10022004', '978-0-12123-124-0', 'The Philosophy of Psychology', 'George Botterill', '100 - Philisophy and psychology', 'Textbook', '1999', 'ArtPostAsia Inc.', 'A/F The Athenaeum, 160 Leviste St., Makati City', '1999 John Q. Smith', 'Available', '');
INSERT INTO `tbl_book` VALUES ('10022005', '978-0-12123-124-0', 'The Philosophy of Psychology', 'George Botterill', '100 - Philisophy and psychology', 'Textbook', '1999', 'ArtPostAsia Inc.', 'A/F The Athenaeum, 160 Leviste St., Makati City', '1999 John Q. Smith', 'Available', '');
INSERT INTO `tbl_book` VALUES ('21022001', '978-3-53545-233-5', 'The Church in Africa', 'Hildebrandt Jonathan', '210 - Religion', 'Textbook', '1996', 'Africa Christian Press, Ghana', 'Opp. Melcom, Adabraka, Accra, Ghana', '1996 Lisa Shea', 'Available', '');
INSERT INTO `tbl_book` VALUES ('21022002', '978-3-53545-233-5', 'The Church in Africa', 'Hildebrandt Jonathan', '210 - Religion', 'Textbook', '1996', 'Africa Christian Press, Ghana', 'Opp. Melcom, Adabraka, Accra, Ghana', '1996 Lisa Shea', 'Available', '');
INSERT INTO `tbl_book` VALUES ('21022003', '978-3-53545-233-5', 'The Church in Africa', 'Hildebrandt Jonathan', '210 - Religion', 'Textbook', '1996', 'Africa Christian Press, Ghana', 'Opp. Melcom, Adabraka, Accra, Ghana', '1996 Lisa Shea', 'Available', '');
INSERT INTO `tbl_book` VALUES ('21022005', '978-3-53545-233-5', 'The Church in Africa', 'Hildebrandt Jonathan', '210 - Religion', 'Textbook', '1996', 'Africa Christian Press, Ghana', 'Opp. Melcom, Adabraka, Accra, Ghana', '1996 Lisa Shea', 'Available', '');
INSERT INTO `tbl_book` VALUES ('30022001', '978-1-23322-456-5', 'Social Science: An Introduction to the Study of Society', 'David Colander, Elgin Hunt', '300 - Social sciences', 'Textbook', '2019', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('30022002', '978-1-23322-456-5', 'Social Science: An Introduction to the Study of Society', 'David Colander, Elgin Hunt', '300 - Social sciences', 'Textbook', '2019', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Borrowed', '');
INSERT INTO `tbl_book` VALUES ('30022003', '978-1-23322-456-5', 'Social Science: An Introduction to the Study of Society', 'David Colander, Elgin Hunt', '300 - Social sciences', 'Textbook', '2019', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('30022004', '978-1-23322-456-5', 'Social Science: An Introduction to the Study of Society', 'David Colander, Elgin Hunt', '300 - Social sciences', 'Textbook', '2019', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('30022005', '978-1-23322-456-5', 'Social Science: An Introduction to the Study of Society', 'David Colander, Elgin Hunt', '300 - Social sciences', 'Textbook', '2019', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('40022001', '978-2-54335-423-8', 'Introducing English Language', 'Louise Mullany, Peter Stockwell', '400 - Language', 'Textbook', '2015', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('40022002', '978-2-54335-423-8', 'Introducing English Language', 'Louise Mullany, Peter Stockwell', '400 - Language', 'Textbook', '2015', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('40022003', '978-2-54335-423-8', 'Introducing English Language', 'Louise Mullany, Peter Stockwell', '400 - Language', 'Textbook', '2015', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Borrowed', '');
INSERT INTO `tbl_book` VALUES ('40022004', '978-2-54335-423-8', 'Introducing English Language', 'Louise Mullany, Peter Stockwell', '400 - Language', 'Textbook', '2015', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('40022005', '978-2-54335-423-8', 'Introducing English Language', 'Louise Mullany, Peter Stockwell', '400 - Language', 'Textbook', '2015', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', 'Available', '');
INSERT INTO `tbl_book` VALUES ('57022001', '971-8-23134-458-0', 'Science and Technology Biology II', 'Unknown', '570 - Science', 'Textbook', '2013', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2013 Bill E. Elliot', 'Available', '');
INSERT INTO `tbl_book` VALUES ('57022002', '971-8-23134-458-0', 'Science and Technology Biology II', 'Unknown', '570 - Science', 'Textbook', '2013', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2013 Bill E. Elliot', 'Available', '');
INSERT INTO `tbl_book` VALUES ('57022003', '971-8-23134-458-0', 'Science and Technology Biology II', 'Unknown', '570 - Science', 'Textbook', '2013', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2013 Bill E. Elliot', 'Available', '');
INSERT INTO `tbl_book` VALUES ('57022004', '971-8-23134-458-0', 'Science and Technology Biology II', 'Unknown', '570 - Science', 'Textbook', '2013', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2013 Bill E. Elliot', 'Available', '');
INSERT INTO `tbl_book` VALUES ('57022005', '971-8-23134-458-0', 'Science and Technology Biology II', 'Unknown', '570 - Science', 'Textbook', '2013', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2013 Bill E. Elliot', 'Available', '');
INSERT INTO `tbl_book` VALUES ('60422001', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', 'Borrowed', '');
INSERT INTO `tbl_book` VALUES ('60422002', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', 'Borrowed', '');
INSERT INTO `tbl_book` VALUES ('60422003', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', 'Available', '');
INSERT INTO `tbl_book` VALUES ('60422004', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', 'Available', '');
INSERT INTO `tbl_book` VALUES ('60422005', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', 'Available', '');
INSERT INTO `tbl_book` VALUES ('70022001', '978-2-32321-009-2', 'Enjoy Life with P.E. and Health', 'Grace Estela C. Mateo, Ph. D.', '700 - Arts and recreation', 'Textbook', '2010', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2010 Jacques Derrida', 'Available', '');
INSERT INTO `tbl_book` VALUES ('70022002', '978-2-32321-009-2', 'Enjoy Life with P.E. and Health', 'Grace Estela C. Mateo, Ph. D.', '700 - Arts and recreation', 'Textbook', '2010', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2010 Jacques Derrida', 'Available', '');
INSERT INTO `tbl_book` VALUES ('70022003', '978-2-32321-009-2', 'Enjoy Life with P.E. and Health', 'Grace Estela C. Mateo, Ph. D.', '700 - Arts and recreation', 'Textbook', '2010', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2010 Jacques Derrida', 'Available', '');
INSERT INTO `tbl_book` VALUES ('70022004', '978-2-32321-009-2', 'Enjoy Life with P.E. and Health', 'Grace Estela C. Mateo, Ph. D.', '700 - Arts and recreation', 'Textbook', '2010', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2010 Jacques Derrida', 'Available', '');
INSERT INTO `tbl_book` VALUES ('70022005', '978-2-32321-009-2', 'Enjoy Life with P.E. and Health', 'Grace Estela C. Mateo, Ph. D.', '700 - Arts and recreation', 'Textbook', '2010', 'Saint Matthew’s Publishing', '4th Level, First RVC Building, 92 Anonas Street Corner K-6th Street, Brgy. East Kamias, 1102 Quezon ', '2010 Jacques Derrida', 'Available', '');
INSERT INTO `tbl_book` VALUES ('81022001', '978-2-67875-754-1', 'The Norton Anthology of American Literature', 'Robert S. Levine', '810 - Literature', 'Textbook', '1985', 'W. W. Norton & Company.', '500 Fifth Avenue, New York City, New York', '1985 Carol Baker', 'Available', '');
INSERT INTO `tbl_book` VALUES ('81022002', '978-2-67875-754-1', 'The Norton Anthology of American Literature', 'Robert S. Levine', '810 - Literature', 'Textbook', '1985', 'W. W. Norton & Company.', '500 Fifth Avenue, New York City, New York', '1985 Carol Baker', 'Available', '');
INSERT INTO `tbl_book` VALUES ('81022003', '978-2-67875-754-1', 'The Norton Anthology of American Literature', 'Robert S. Levine', '810 - Literature', 'Textbook', '1985', 'W. W. Norton & Company.', '500 Fifth Avenue, New York City, New York', '1985 Carol Baker', 'Available', '');
INSERT INTO `tbl_book` VALUES ('81022004', '978-2-67875-754-1', 'The Norton Anthology of American Literature', 'Robert S. Levine', '810 - Literature', 'Textbook', '1985', 'W. W. Norton & Company.', '500 Fifth Avenue, New York City, New York', '1985 Carol Baker', 'Available', '');
INSERT INTO `tbl_book` VALUES ('81022005', '978-2-67875-754-1', 'The Norton Anthology of American Literature', 'Robert S. Levine', '810 - Literature', 'Textbook', '1985', 'W. W. Norton & Company.', '500 Fifth Avenue, New York City, New York', '1985 Carol Baker', 'Available', '');
INSERT INTO `tbl_book` VALUES ('90022001', '978-1-09872-232-9', 'Araling Panlipunan - Pilipinas (Isang Sulyap at Pagyakap)', 'Michael DC. Rama, Florencia C. Domingo, Jennifer G. Rama, Jayson A. Cruz', '900 - History and Geography', 'Textbook', '2010', 'Asian Escapades Management and Publishing Enterprises', '37 A. Mabini Street, 3000, Malolos City, Bulacan, Philippines', '2010 James Perry', 'Available', '');
INSERT INTO `tbl_book` VALUES ('90022002', '978-1-09872-232-9', 'Araling Panlipunan - Pilipinas (Isang Sulyap at Pagyakap)', 'Michael DC. Rama, Florencia C. Domingo, Jennifer G. Rama, Jayson A. Cruz', '900 - History and Geography', 'Textbook', '2010', 'Asian Escapades Management and Publishing Enterprises', '37 A. Mabini Street, 3000, Malolos City, Bulacan, Philippines', '2010 James Perry', 'Available', '');
INSERT INTO `tbl_book` VALUES ('90022003', '978-1-09872-232-9', 'Araling Panlipunan - Pilipinas (Isang Sulyap at Pagyakap)', 'Michael DC. Rama, Florencia C. Domingo, Jennifer G. Rama, Jayson A. Cruz', '900 - History and Geography', 'Textbook', '2010', 'Asian Escapades Management and Publishing Enterprises', '37 A. Mabini Street, 3000, Malolos City, Bulacan, Philippines', '2010 James Perry', 'Available', '');
INSERT INTO `tbl_book` VALUES ('90022004', '978-1-09872-232-9', 'Araling Panlipunan - Pilipinas (Isang Sulyap at Pagyakap)', 'Michael DC. Rama, Florencia C. Domingo, Jennifer G. Rama, Jayson A. Cruz', '900 - History and Geography', 'Textbook', '2010', 'Asian Escapades Management and Publishing Enterprises', '37 A. Mabini Street, 3000, Malolos City, Bulacan, Philippines', '2010 James Perry', 'Available', '');
INSERT INTO `tbl_book` VALUES ('90022005', '978-1-09872-232-9', 'Araling Panlipunan - Pilipinas (Isang Sulyap at Pagyakap)', 'Michael DC. Rama, Florencia C. Domingo, Jennifer G. Rama, Jayson A. Cruz', '900 - History and Geography', 'Textbook', '2010', 'Asian Escapades Management and Publishing Enterprises', '37 A. Mabini Street, 3000, Malolos City, Bulacan, Philippines', '2010 James Perry', 'Available', '');

-- ----------------------------
-- Table structure for `tbl_borrowedbooks`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_borrowedbooks`;
CREATE TABLE `tbl_borrowedbooks` (
  `BookID` int(255) NOT NULL AUTO_INCREMENT,
  `BookNumber` varchar(255) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `DeweyDecimalClassification` varchar(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `YearofPublication` varchar(255) NOT NULL,
  `Publisher` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Copyright` varchar(255) NOT NULL,
  `DateBorrowed` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(25) NOT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_borrowedbooks
-- ----------------------------
INSERT INTO `tbl_borrowedbooks` VALUES ('53', '60422003', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', '16/11/2022', '17/11/2022', '7001', 'Dr. Marina Gracias Estoesta', '(+63) 977-2130-087');
INSERT INTO `tbl_borrowedbooks` VALUES ('54', '60422002', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', '16/11/2022 - 07:22 pm', '17/11/2022 - 12:00 am', '100816100072', 'Felix Ramos Medina', '(+63) 977-4501-239');
INSERT INTO `tbl_borrowedbooks` VALUES ('55', '60422001', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', '16/11/2022 - 07:22 pm', '19/11/2022 - 12:00 am', '100845150051', 'Princess Jewel Grace Alas Orejudos', '(+63) 939-9774-505');
INSERT INTO `tbl_borrowedbooks` VALUES ('56', '40022003', '978-2-54335-423-8', 'Introducing English Language', 'Louise Mullany, Peter Stockwell', '400 - Language', 'Textbook', '2015', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', '16/11/2022 - 07:26 pm', '19/11/2022', '101007150010', 'Ernest Charl Valdez Geneta', '(+63) 977-4501-236');

-- ----------------------------
-- Table structure for `tbl_borrowednonprinted`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_borrowednonprinted`;
CREATE TABLE `tbl_borrowednonprinted` (
  `MaterialID` int(255) NOT NULL AUTO_INCREMENT,
  `MaterialNumber` varchar(255) NOT NULL,
  `MaterialName` varchar(255) NOT NULL,
  `DateBorrowed` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(255) NOT NULL,
  PRIMARY KEY (`MaterialID`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_borrowednonprinted
-- ----------------------------
INSERT INTO `tbl_borrowednonprinted` VALUES ('32', '1000', 'Globe - World', '15/11/2022', '16/11/2022', '7001', 'Dr. Marina Gracias Estoesta', '(+63) 977-2130-087');
INSERT INTO `tbl_borrowednonprinted` VALUES ('33', '1001', 'Globe - World', '15/11/2022', '15/11/2022', '7002', 'Mrs. Tricia Mae Laplana Carbonell', '(+63) 977-2130-090');
INSERT INTO `tbl_borrowednonprinted` VALUES ('34', '1002', 'Globe - World', '15/11/2022', '17/11/2022', '100816100072', 'Felix Ramos Medina', '(+63) 977-4501-239');
INSERT INTO `tbl_borrowednonprinted` VALUES ('35', '2000', 'Periodic Table', '15/11/2022', '18/11/2022', '100845150051', 'Princess Jewel Grace Alas Orejudos', '(+63) 939-9774-505');
INSERT INTO `tbl_borrowednonprinted` VALUES ('36', '2001', 'Periodic Table', '15/11/2022', '16/11/2022', '101007150010', 'Ernest Charl Valdez Geneta', '(+63) 977-4501-236');
INSERT INTO `tbl_borrowednonprinted` VALUES ('37', '2002', 'Periodic Table', '14/11/2022', '14/11/2022', '101090140013', 'Francis Bryan Villanueva Hidalgo', '(+63) 977-4501-237');
INSERT INTO `tbl_borrowednonprinted` VALUES ('38', '3000', 'Philippine Map', '15/11/2022', '15/11/2022', '101090140013', 'Francis Bryan Villanueva Hidalgo', '(+63) 977-4501-237');
INSERT INTO `tbl_borrowednonprinted` VALUES ('39', '3001', 'Philippine Map', '15/11/2022', '16/11/2022', '7004', 'Mrs. Jesusa Dulay Villanueva', '(+63) 951-7238-230');
INSERT INTO `tbl_borrowednonprinted` VALUES ('40', '3002', 'Philippine Map', '15/11/2022', '16/11/2022', '7005', 'Mr. Jeremy Parado Marquez', '(+63) 977-2372-993');
INSERT INTO `tbl_borrowednonprinted` VALUES ('41', '4000', 'World Map', '15/11/2022', '17/11/2022', '101090140045', 'Regine Emperador Gepega', '(+63) 939-9774-502');

-- ----------------------------
-- Table structure for `tbl_borrowreturnbooks`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_borrowreturnbooks`;
CREATE TABLE `tbl_borrowreturnbooks` (
  `BookNumber` varchar(255) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `DeweyDecimalClassification` varchar(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `YearofPublication` varchar(255) NOT NULL,
  `Publisher` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Copyright` varchar(255) NOT NULL,
  `DateBorrowed` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(255) NOT NULL,
  PRIMARY KEY (`BookNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_borrowreturnbooks
-- ----------------------------
INSERT INTO `tbl_borrowreturnbooks` VALUES ('40022003', '978-2-54335-423-8', 'Introducing English Language', 'Louise Mullany, Peter Stockwell', '400 - Language', 'Textbook', '2015', 'Routledge', 'Milton Park, Abingdon-on-Thames, Oxforshire, England, UK', '2019 Colleen Hover', '16/11/2022 - 07:26 pm', '17/11/2022', '101007150010', 'Ernest Charl Valdez Geneta', '(+63) 977-4501-236');
INSERT INTO `tbl_borrowreturnbooks` VALUES ('60422001', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', '16/11/2022 - 07:22 pm', '19/11/2022 - 12:00 am', '100845150051', 'Princess Jewel Grace Alas Orejudos', '(+63) 939-9774-505');
INSERT INTO `tbl_borrowreturnbooks` VALUES ('60422002', '978-9-23123-231-7', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '570 - Science', 'General Reference', '2019', 'SDC Publications', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', '16/11/2022 - 07:22 pm', '17/11/2022 - 12:00 am', '100816100072', 'Felix Ramos Medina', '(+63) 977-4501-239');

-- ----------------------------
-- Table structure for `tbl_borrowreturnnonprinted`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_borrowreturnnonprinted`;
CREATE TABLE `tbl_borrowreturnnonprinted` (
  `MaterialNumber` varchar(255) NOT NULL,
  `MaterialName` varchar(255) NOT NULL,
  `DateBorrowed` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(255) NOT NULL,
  PRIMARY KEY (`MaterialNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_borrowreturnnonprinted
-- ----------------------------
INSERT INTO `tbl_borrowreturnnonprinted` VALUES ('3001', 'Philippine Map', '15/11/2022', '16/11/2022', '7004', 'Mrs. Jesusa Dulay Villanueva', '(+63) 951-7238-230');
INSERT INTO `tbl_borrowreturnnonprinted` VALUES ('4000', 'World Map', '15/11/2022', '17/11/2022', '101090140045', 'Regine Emperador Gepega', '(+63) 939-9774-502');

-- ----------------------------
-- Table structure for `tbl_damagedbooks`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_damagedbooks`;
CREATE TABLE `tbl_damagedbooks` (
  `BookID` int(255) NOT NULL AUTO_INCREMENT,
  `BookNumber` varchar(255) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `DeweyDecimalClassification` varchar(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `YearofPublication` varchar(255) NOT NULL,
  `Publisher` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Copyright` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `DateReturned` varchar(255) NOT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_damagedbooks
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_damagednonprinted`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_damagednonprinted`;
CREATE TABLE `tbl_damagednonprinted` (
  `MaterialID` int(255) NOT NULL AUTO_INCREMENT,
  `MaterialNumber` varchar(255) NOT NULL,
  `MaterialName` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `DateReturned` varchar(255) NOT NULL,
  PRIMARY KEY (`MaterialID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_damagednonprinted
-- ----------------------------
INSERT INTO `tbl_damagednonprinted` VALUES ('15', '2000', 'Periodic Table', 'Princess Jewel Grace Alas Orejudos', '15/11/2022');
INSERT INTO `tbl_damagednonprinted` VALUES ('16', '2001', 'Periodic Table', 'Ernest Charl Valdez Geneta', '15/11/2022');
INSERT INTO `tbl_damagednonprinted` VALUES ('17', '2002', 'Periodic Table', 'Francis Bryan Villanueva Hidalgo', '15/11/2022');

-- ----------------------------
-- Table structure for `tbl_delinquentborrowers`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_delinquentborrowers`;
CREATE TABLE `tbl_delinquentborrowers` (
  `ItemID` int(255) NOT NULL AUTO_INCREMENT,
  `ItemNumber` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  `DateReturned` varchar(255) NOT NULL,
  `Reason` varchar(255) NOT NULL,
  PRIMARY KEY (`ItemID`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_delinquentborrowers
-- ----------------------------
INSERT INTO `tbl_delinquentborrowers` VALUES ('25', '2002', '101090140013', 'Francis Bryan Villanueva Hidalgo', '14/11/2022', '15/11/2022', 'nakalimutan');

-- ----------------------------
-- Table structure for `tbl_faculty`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_faculty`;
CREATE TABLE `tbl_faculty` (
  `Username` int(50) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(50) NOT NULL,
  `AdvisoryClass` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `ImagePath` varchar(50) NOT NULL,
  PRIMARY KEY (`Username`),
  KEY `Username` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_faculty
-- ----------------------------
INSERT INTO `tbl_faculty` VALUES ('7001', 'Dr. Marina Gracias Estoesta', '(+63) 977-2130-087', '', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7002', 'Mrs. Tricia Mae Laplana Carbonell', '(+63) 977-2130-090', '7-Narra', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7003', 'Mrs. Ruth Rivera Maestro', '(+63) 921-3323-002', '7-Camachile', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7004', 'Mrs. Jesusa Dulay Villanueva', '(+63) 951-7238-230', '8-Ipil-Ipil', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7005', 'Mr. Jeremy Parado Marquez', '(+63) 977-2372-993', '8-Molave', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7006', 'Mrs. Jobelle Picar Rocapor', '(+63) 999-2323-404', '9-Kamagong', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7007', 'Mr. Frank Quidit Calub Jr', '(+63) 987-2334-499', '9-Olive', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7008', 'Mrs. Imelda Garcia Gracias', '(+63) 977-2340-023', '10-Acacia', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7009', 'Mrs. Catherine F. Carbonell', '(+63) 923-2300-823', '11-GAS', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7010', 'Dr. John-John Q. Garcia', '(+63) 977-2131-237', '12-GAS', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7011', 'Ms. Charlene Mae G. Gracias', '(+63) 988-2323-093', '12-HUMMS', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7012', 'Mr. Jeffrey C. Galera', '(+63) 987-3200-323', '11-HUMMS', 'password', '');
INSERT INTO `tbl_faculty` VALUES ('7020', 'Patrick Grey', '(+63) 995-1178-725', '12-TVL', 'password', 'C:\\Barcode\\7020.jpg');
INSERT INTO `tbl_faculty` VALUES ('7030', 'Haries Bening', '(+63) 992-3131-232', '11-TVL', 'password', 'C:\\Barcode\\7030.jpg');

-- ----------------------------
-- Table structure for `tbl_facultyborrowers`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_facultyborrowers`;
CREATE TABLE `tbl_facultyborrowers` (
  `Username` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(255) NOT NULL,
  `ItemID` int(255) NOT NULL AUTO_INCREMENT,
  `ItemNumber` varchar(255) NOT NULL,
  `ItemType` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `DateBorrowed` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  PRIMARY KEY (`ItemID`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_facultyborrowers
-- ----------------------------
INSERT INTO `tbl_facultyborrowers` VALUES ('7001', 'Dr. Marina Gracias Estoesta', '(+63) 977-2130-087', '25', '1000', 'Non-Printed', 'Globe - World', '15/11/2022', '16/11/2022');
INSERT INTO `tbl_facultyborrowers` VALUES ('7002', 'Mrs. Tricia Mae Laplana Carbonell', '(+63) 977-2130-090', '26', '1001', 'Non-Printed', 'Globe - World', '15/11/2022', '15/11/2022');
INSERT INTO `tbl_facultyborrowers` VALUES ('7004', 'Mrs. Jesusa Dulay Villanueva', '(+63) 951-7238-230', '27', '3001', 'Non-Printed', 'Philippine Map', '15/11/2022', '16/11/2022');
INSERT INTO `tbl_facultyborrowers` VALUES ('7005', 'Mr. Jeremy Parado Marquez', '(+63) 977-2372-993', '28', '3002', 'Non-Printed', 'Philippine Map', '15/11/2022', '16/11/2022');

-- ----------------------------
-- Table structure for `tbl_lostbooks`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_lostbooks`;
CREATE TABLE `tbl_lostbooks` (
  `BookNumber` varchar(255) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `DeweyDecimalClassification` varchar(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `YearofPublication` varchar(255) NOT NULL,
  `Publisher` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Copyright` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  PRIMARY KEY (`BookNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_lostbooks
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_lostnonprinted`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_lostnonprinted`;
CREATE TABLE `tbl_lostnonprinted` (
  `MaterialNumber` varchar(255) NOT NULL,
  `MaterialName` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  PRIMARY KEY (`MaterialNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_lostnonprinted
-- ----------------------------
INSERT INTO `tbl_lostnonprinted` VALUES ('3000', 'Philippine Map', 'Francis Bryan Villanueva Hidalgo', '15/11/2022');

-- ----------------------------
-- Table structure for `tbl_nonprinted`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_nonprinted`;
CREATE TABLE `tbl_nonprinted` (
  `MaterialNumber` int(255) NOT NULL AUTO_INCREMENT,
  `MaterialName` varchar(255) NOT NULL,
  `Status` varchar(255) NOT NULL,
  `ImagePath` varchar(255) NOT NULL,
  PRIMARY KEY (`MaterialNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=12212122 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_nonprinted
-- ----------------------------
INSERT INTO `tbl_nonprinted` VALUES ('1000', 'Globe - World', 'Available', 'C:\\Barcode\\1000.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('1001', 'Globe - World', 'Available', 'C:\\Barcode\\1001.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('1002', 'Globe - World', 'Available', 'C:\\Barcode\\1002.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('2000', 'Periodic Table', 'Available', 'C:\\Barcode\\2000.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('2001', 'Periodic Table', 'Available', 'C:\\Barcode\\2001.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('2002', 'Periodic Table', 'Available', 'C:\\Barcode\\2002.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('3000', 'Philippine Map', 'Lost', 'C:\\Barcode\\3000.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('3001', 'Philippine Map', 'Borrowed', 'C:\\Barcode\\3001.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('3002', 'Philippine Map', 'Available', 'C:\\Barcode\\3002.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('4000', 'World Map', 'Borrowed', 'C:\\Barcode\\4000.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('4001', 'World Map', 'Available', 'C:\\Barcode\\4001.jpg');
INSERT INTO `tbl_nonprinted` VALUES ('4002', 'World Map', 'Available', 'C:\\Barcode\\4002.jpg');

-- ----------------------------
-- Table structure for `tbl_overduebooks`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_overduebooks`;
CREATE TABLE `tbl_overduebooks` (
  `BookID` int(255) NOT NULL AUTO_INCREMENT,
  `BookNumber` varchar(255) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `DeweyDecimalClassification` varchar(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `YearofPublication` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  `DateReturned` varchar(255) NOT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_overduebooks
-- ----------------------------

-- ----------------------------
-- Table structure for `tbl_overduenonprinted`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_overduenonprinted`;
CREATE TABLE `tbl_overduenonprinted` (
  `MaterialID` int(255) NOT NULL AUTO_INCREMENT,
  `MaterialNumber` varchar(255) NOT NULL,
  `MaterialName` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  `DateReturned` varchar(255) NOT NULL,
  PRIMARY KEY (`MaterialID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_overduenonprinted
-- ----------------------------
INSERT INTO `tbl_overduenonprinted` VALUES ('14', '2002', 'Periodic Table', '14/11/2022', '15/11/2022');

-- ----------------------------
-- Table structure for `tbl_returnedbooks`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_returnedbooks`;
CREATE TABLE `tbl_returnedbooks` (
  `BookID` int(255) NOT NULL AUTO_INCREMENT,
  `BookNumber` varchar(255) NOT NULL,
  `ISBN` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `DeweyDecimalClassification` varchar(255) NOT NULL,
  `Category` varchar(255) NOT NULL,
  `YearofPublication` varchar(255) NOT NULL,
  `Publisher` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Copyright` varchar(255) NOT NULL,
  `DateReturned` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_returnedbooks
-- ----------------------------
INSERT INTO `tbl_returnedbooks` VALUES ('41', '00522001', '978-4-54349-094-2', 'Information Technology', 'Richard Fox', 'Computer science, information and general works', 'Textbook', '2015', 'Chapman and Hall/CRC.', 'Class 005', '', '28/10/2022', '101090130036', 'Mel Dheon Munar Jucutan');
INSERT INTO `tbl_returnedbooks` VALUES ('42', '60422003', '978-9-23123-231-7', 'PO Box 1334, Mission, Kansas, 66222, United States', '2019 Leonard Piekoff', '570 - Science', 'General Reference', 'Technical Drawing 101 with AutoCAD', 'Ashleigh Congdon-Fuller, Antonio Ramirez, Douglas Smith', '2019', 'SDC Publications', '16/11/2022', '7001', 'Dr. Marina Gracias Estoesta');

-- ----------------------------
-- Table structure for `tbl_returnednonprinted`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_returnednonprinted`;
CREATE TABLE `tbl_returnednonprinted` (
  `MaterialID` int(255) NOT NULL AUTO_INCREMENT,
  `MaterialNumber` varchar(255) NOT NULL,
  `MaterialName` varchar(255) NOT NULL,
  `DateReturned` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`MaterialID`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_returnednonprinted
-- ----------------------------
INSERT INTO `tbl_returnednonprinted` VALUES ('16', '1000', 'Globe - World', '28/10/2022', '7002', 'Mrs. Tricia Mae Laplana Carbonell');
INSERT INTO `tbl_returnednonprinted` VALUES ('17', '1000', 'Globe - World', '15/11/2022', '7001', 'Dr. Marina Gracias Estoesta');
INSERT INTO `tbl_returnednonprinted` VALUES ('18', '1001', 'Globe - World', '15/11/2022', '7002', 'Mrs. Tricia Mae Laplana Carbonell');
INSERT INTO `tbl_returnednonprinted` VALUES ('19', '1002', 'Globe - World', '15/11/2022', '100816100072', 'Felix Ramos Medina');
INSERT INTO `tbl_returnednonprinted` VALUES ('20', '2000', 'Periodic Table', '15/11/2022', '100845150051', 'Princess Jewel Grace Alas Orejudos');
INSERT INTO `tbl_returnednonprinted` VALUES ('21', '2001', 'Periodic Table', '15/11/2022', '101007150010', 'Ernest Charl Valdez Geneta');
INSERT INTO `tbl_returnednonprinted` VALUES ('22', '2002', 'Periodic Table', '15/11/2022', '101090140013', 'Francis Bryan Villanueva Hidalgo');
INSERT INTO `tbl_returnednonprinted` VALUES ('23', '3002', 'Philippine Map', '16/11/2022', '7005', 'Mr. Jeremy Parado Marquez');

-- ----------------------------
-- Table structure for `tbl_student`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_student`;
CREATE TABLE `tbl_student` (
  `Username` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(25) NOT NULL,
  `GradeSec` varchar(50) NOT NULL,
  `Teacher` varchar(255) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `ImagePath` varchar(50) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_student
-- ----------------------------
INSERT INTO `tbl_student` VALUES ('100809100001', 'Paula Marie Padin Abanes', '(+63) 900-2345-800', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('100816100072', 'Felix Ramos Medina', '(+63) 977-4501-239', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('100826130014', 'Renz Aldwin Abubo Mamuyac', '(+63) 949-8177-022', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('100845150051', 'Princess Jewel Grace Alas Orejudos', '(+63) 939-9774-505', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('100919100025', 'Rovelyn Gonzales Ventura', '(+63) 973-4231-112', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('100929140032', 'Orlando De Gracia Gapuz III', '(+63) 995-7892-811', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('100942110012', 'Argie Piamonte Lachica', '(+63) 977-6422-311', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('100999100038', 'Danica Dacanay Ventura', '(+63) 997-6212-023', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101005120010', 'Angie Lyn Catbagan Mamuyac', '(+63) 988-8231-198', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101007130024', 'Adelfa Jucutan Acosta', '(+63) 921-1223-119', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101007140003', 'Justine Mark Jucutan Acosta', '(+63) 995-7892-800', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101007150010', 'Ernest Charl Valdez Geneta', '(+63) 977-4501-236', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101029140013', 'Lorie Peralta Ursua', '(+63) 996-1785-243', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101036080135', 'Ryan William Halog Oropilla', '(+63) 923-6532-334', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101089110012', 'Melanie Orpilla Villanueva', '(+63) 949-8177-049', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100001', 'Aljean Daligdig Acosta', '(+63) 956-3434-523', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100002', 'Crisanto Rosete Acosta', '(+63) 987-4312-859', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100003', 'Jerome Peralta Acosta', '(+63) 934-2677-543', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100004', 'Mariel Dacanay Acosta', '(+63) 974-5789-022', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100005', 'Justin Niñalga Baylon', '(+63) 923-4987-654', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100006', 'Mark Jurell Leoncion Besin', '(+63) 953-4256-543', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100007', 'Louiza Rae Rivera Boado', '(+63) 965-4000-123', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100008', 'Cylene Joy Carpio Calub', '(+63) 977-1234-567', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100010', 'Jovan Hufalar Catbagan', '(+63) 985-4323-632', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100015', 'Julius Grandia Daligdig', '(+63) 999-2335-432', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100016', 'Paul Briane Villanueva Daligdig', '(+63) 912-3456-543', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100017', 'Chardine Jucutan De Gracia', '(+63) 433-2334-334', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100018', 'Mariane Joy Leoncion De Gracia', '(+63) 965-4232-322', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100021', 'Alona Medina Emperador', '(+63) 977-1234-680', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100022', 'Erna Monzales Emperador', '(+63) 949-8135-650', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100023', 'Gio Medina Emperador', '(+63) 923-0535-098', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100024', 'Noel Jr Ballesteros Estacio', '(+63) 907-6543-456', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100025', 'Stephen Gracias Estacio', '(+63) 901-2345-678', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100027', 'John Marc Cagujas Pugal', '(+63) 912-3657-475', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100028', 'Karina Joyce Boado Geneta', '(+63) 951-7856-422', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100030', 'Ira Jayne Garcia Gracias', '(+63) 934-2342-342', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100031', 'Jaime Jr Catbagan Jucutan', '(+63) 907-8765-434', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100035', 'Joana Marie De Gracia Marquez', '(+63) 946-2349-654', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100036', 'Jasper John Rivera Mendoza', '(+63) 944-3252-334', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100037', 'Karylle Padin Montemayor', '(+63) 987-1230-233', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100038', 'Joey De Gracia Munar', '(+63) 976-5434-120', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100039', 'Norshel Cruz Munar', '(+63) 934-2362-232', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100040', 'Noemi Nipa Nardo', '(+63) 995-1671-234', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100042', 'Princess Ubalde Padin', '(+63) 954-6123-853', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100047', 'Angel Oropilla Ridual', '(+63) 974-5234-223', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100049', 'Christine Medina Rimas', '(+63) 987-4560-034', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100053', 'Mark Ferrer Salas', '(+63) 949-8177-029', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100054', 'Shaina Parado Sesaldo', '(+63) 934-8234-233', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100055', 'Benjie Nisperos Verceles', '(+63) 912-0506-890', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100056', 'Jacquilyn Jampit Verceles', '(+63) 923-1222-211', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100057', 'Jocelyn Quiroga Verceles', '(+63) 943-5234-232', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100058', 'John Ismael Montemayor Villanueva', '(+63) 932-5233-001', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090100060', 'Raymel Catbagan Villanueva', '(+63) 975-4345-896', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110001', 'Mark Joseph Casison Abunda', '(+63) 912-3456-765', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110003', 'Lhe Anne Dacanay Acosta', '(+63) 953-9001-232', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110004', 'Philip Angel Acosta Alibayan', '(+63) 965-2213-111', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110005', 'Tyrone Sean Leoncion Ammalin', '(+63) 977-6213-123', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110006', 'Reden Parado Aspillaga', '(+63) 932-3211-219', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110008', 'Luigi Calub Ballesteros', '(+63) 912-0008-732', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110010', 'Charlene Rimas Calub', '(+63) 977-5565-112', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110011', 'Syrell Mamuyac Calub', '(+63)    -    -', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110012', 'Carl Stephen Pineda Caoile', '(+63) 932-3111-905', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110013', 'Roxane Jucutan Castro', '(+63) 988-1232-133', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110015', 'Cyrus Niñalga Costales', '(+63) 912-3323-455', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110016', 'Mike Bilog Dacanay', '(+63) 916-7654-689', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110018', 'Mark Christian Tavas Daligdig', '(+63) 976-3231-112', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110020', 'Leslie Anne Ducusin Domanay', '(+63) 977-1231-234', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110022', 'Eric Aquino Emperador', '(+63) 934-2322-222', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110023', 'Jan Rick Quinones Gallardo', '(+63) 976-5322-223', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110025', 'Mc Arthur Ridual Hufalar', '(+63) 942-2222-231', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110026', 'Johary Acosta Jarabe', '(+63) 973-4231-112', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110027', 'Chrisha Mae Munar Jucutan', '(+63) 976-5432-222', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110030', 'Jamaica Garcia Marquez', '(+63) 977-1210-029', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110031', 'Jonah Mae Leoncion Marquez', '(+63) 977-4211-131', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110032', 'Kevin Acosta Maynes', '(+63) 977-1400-212', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110037', 'Cristine Paras Nipa', '(+63) 999-3132-232', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110038', 'Daniella Marie Dayag Nipa', '(+63) 964-5343-122', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110040', 'Alona Boadilla Ocampo', '(+63) 977-1200-023', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110041', 'Mark Angelo Verceles Ordoño', '(+63) 989-7632-233', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110042', 'Menard Ryan Verceles Ordoño', '(+63) 977-5459-000', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110043', 'Gabriela Ridual Padin', '(+63) 975-3258-222', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110044', 'Kurt Darelle Dagatan Pineda', '(+63) 995-1783-243', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110047', 'Joshua Rofert Lumauig Rivera', '(+63) 991-2312-111', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110050', 'John Paul Rivera Verceles', '(+63) 949-8774-122', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090110056', 'John Alfred Parado Viloria', '(+63) 991-2341-202', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120001', 'Justine Riguer Garcia', '(+63) 949-7177-013', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120005', 'Cidrick Verceles Acosta', '(+63) 949-7177-037', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120006', 'Jeremy Dacanay Acosta', '(+63) 949-7177-038', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120014', 'Ken Mavericks Leoncion Besin', '(+63) 949-7177-039', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120018', 'Aron Acosta Jarabe', '(+63) 949-7177-014', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120020', 'Shan Jiro Padin Navarro', '(+63) 971-3123-131', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120021', 'Fredrich Congayao Niñalga', '(+63) 953-4523-422', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120023', 'Ivan Dagatan Pineda', '(+63) 945-3421-121', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120026', 'Ace Patrick Padin Tabernero', '(+63) 973-1211-112', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120027', 'Regie Niñalga Villanueva', '(+63) 912-3111-123', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120030', 'Jessa Mhee Campos Calub', '(+63) 900-1221-241', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120031', 'Maria Cristina Angelica Calub Cayuhen', '(+63) 976-5431-113', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120034', 'Grashiela Mae Mamuyac Daligdig', '(+63) 977-5120-091', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120035', 'Rholyn Yares De Gracia', '(+63) 988-7732-233', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120036', 'Christel Joy Bautista Estacio', '(+63) 973-2311-223', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120037', 'Andrea Mae Dacanay Geneta', '(+63) 977-2322-221', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090120040', 'Claire Nipa Nipa', '(+63) 973-2313-122', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130001', 'Elner Coronel Acosta', '(+63) 949-8177-007', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130002', 'Gian Carlo Medina Acosta', '(+63) 949-8177-008', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130003', 'Angelo Daligdig Bautista', '(+63) 977-1499-778', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130004', 'Jovart Campos Calub', '(+63) 949-8177-009', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130005', 'Denver Kurt Tulingan Catbagan', '(+63) 949-8177-010', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130006', 'Jereco Estacio Dacanay', '(+63) 949-8177-013', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130007', 'Cedrick Gracias Estacio', '(+63) 977-1499-714', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130008', 'Jerome Ballesteros Estacio', '(+63) 949-8177-015', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130009', 'Reneboy Carbonell Ferrer', '(+63) 977-1499-715', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130010', 'Rhian Acosta Lachica', '(+63) 977-1499-718', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130011', 'Sherwin Cruz Munar', '(+63) 977-1499-723', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130012', 'Mark Aaron Ashley Sabela Padin', '(+63) 949-8177-023', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130013', 'Mark Jhun Fonseca Padin', '(+63) 949-8177-024', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130014', 'James Cesar Boado Paredes', '(+63) 949-8177-026', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130016', 'Jiecel Verceles Aspuria', '(+63) 977-1499-729', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130020', 'Kylie Mae Catbagan Daligdig', '(+63) 949-8177-036', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130022', 'Danica Joy Bilog Eslava', '(+63) 949-8177-041', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130024', 'Christine Emperador Gepega', '(+63) 995-7892-822', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130025', 'Kim Acosta Maynes', '(+63) 949-8177-045', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130027', 'April Heart Hufalar Verceles', '(+63) 996-1785-244', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130030', 'Marlon Acosta Catbagan Jr', '(+63) 949-8177-011', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130031', 'Ryan Verceles Catbagan', '(+63) 949-8177-012', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130032', 'Manny Bilog Dacanay', '(+63) 977-1499-711', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130033', 'Chris Jared Tavas Daligdig', '(+63) 977-1499-712', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130034', 'Mark James Padin Dulay', '(+63) 949-8177-014', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130035', 'Benedict Aviles Hufalar', '(+63) 949-8177-018', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130036', 'Mel Dheon Munar Jucutan', '(+63) 977-1499-716', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130037', 'Jaylord Diez Leoncion', '(+63) 977-1499-719', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130040', 'David Andrie Dayag Nipa', '(+63) 977-1499-724', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130042', 'Ryan Dave Emperador Rimas', '(+63) 995-1785-222', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130043', 'Gian Dave Parado Toledo', '(+63)    -    -', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130044', 'Aldred Jade Estacio Villanueva', '(+63) 977-1499-726', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130045', 'Bea Myquelle Celine Leoncion Ammalin', '(+63) 977-1499-728', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130047', 'Rica Nemia Grandia Daligdig', '(+63) 949-8177-038', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130051', 'Micah Ella Cacanando Nipa', '(+63) 949-8177-047', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090130054', 'Eriah Blessy Montemayor Tillay', '(+63) 949-8177-048', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140002', 'James Ivan Catbagan Boado', '(+63) 995-7892-802', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140004', 'Marvin Jr Pineda Caoile', '(+63) 995-7892-804', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140005', 'Justine Luke Hufalar Catbagan', '(+63) 995-7892-805', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140006', 'Romel Verceles Catbagan', '(+63) 995-7892-805', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140007', 'Kenneth Cacabelos Dacanay', '(+63) 995-1785-211', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140008', 'Lemuel John Erosa Dacanay', '(+63) 995-1785-212', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140009', 'Justin Catbagan Daligdig', '(+63) 995-7892-806', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140010', 'Rodel Mamuyac Daligdig', '(+63) 995-7892-807', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140011', 'Christian Zane Pobre Dulos', '(+63) 995-7892-808', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140012', 'Aldrin Medina Emperador', '(+63) 995-1785-213', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140013', 'Francis Bryan Villanueva Hidalgo', '(+63) 977-4501-237', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140014', 'Russel Andrie Catu Lachica', '(+63) 995-1785-216', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140016', 'Alexis Emperador Nipa', '(+63) 995-1785-219', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140017', 'George Jairus Ridual Padin', '(+63) 995-7892-816', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140020', 'John Paul Catbagan Ruam', '(+63) 995-1785-223', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140021', 'Dranreb Seonne Parado Toledo', '(+63) 995-7892-817', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140022', 'Jay Mark Ubalde Velasquez', '(+63) 996-1785-224', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140023', 'Jaspher Hufalar Verceles', '(+63) 996-1785-225', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140024', 'Jureson Nisperos Verceles', '(+63)    -    -', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140025', 'Mc James Catbagan Verceles', '(+63)    -    -', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140027', 'Mark Ridual Hufalar', '(+63) 995-1785-215', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140028', 'Aicy Belleza Acosta', '(+63) 995-7892-817', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140029', 'Gherickylle Shine Rivera Cabera', '(+63) 996-1785-227', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140031', 'Bea Rimas Calub', '(+63) 996-1785-228', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140032', 'Jessica Mae Mamuyac Calub', '(+63) 996-1785-229', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140033', 'Divine Tabernero Caoile', '(+63) 996-1785-229', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140034', 'Jolan Aquino Casison', '(+63) 996-1785-230', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140035', 'Cathlyn Joy Veronica Calub Cayuhen', '(+63) 996-1785-231', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140037', 'Jasmine Ninalga Costales', '(+63) 995-7892-819', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140038', 'Jenica Shane Leoncion Dela Cruz', '(+63) 996-1785-233', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140039', 'Elnoraine Bacalzo Domondon', '(+63) 995-7892-819', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140040', 'Joeynah Verceles Dulay', '(+63) 996-1785-234', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140043', 'Aira Jane Dacanay Geneta', '(+63) 996-1785-236', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140044', 'Jasmine Caballero Geneta', '(+63) 995-7892-821', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140045', 'Regine Emperador Gepega', '(+63) 939-9774-502', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140046', 'Precious Mae Tanagon Hufalar', '(+63) 995-7892-824', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140047', 'Lea Ellaine Munar Licudo', '(+63) 995-7892-825', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140048', 'Kristine Gail Parado Munar', '(+63) 996-1785-237', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140049', 'Rose Marie Verceles Noces', '(+63) 996-1785-238', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140050', 'Gemma May Dacanay Paculan', '(+63) 996-1785-239', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140051', 'Hazel Anne Gatchalian Parado', '(+63) 996-1785-240', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140052', 'Stephanie Munar Ruam', '(+63) 981-2234-003', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140053', 'Mary Joy Ferrer Salas', '(+63) 957-8321-123', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140054', 'Keann Louise Soque', '(+63) 996-1785-242', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140055', 'Princess Angela Castro Tadefa', '(+63) 981-2234-004', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140063', 'Princess Tuazon Daligdig', '(+63) 949-8177-037', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140064', 'Reyna Reyes Dulay', '(+63) 949-8177-040', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140066', 'Joyce Mae Catbagan Colobong', '(+63) 976-1421-122', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090140072', 'John Paul Hufalar Verceles', '(+63) 977-1123-009', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150001', 'Dave Zandrix De Gracia Anolin', '(+63) 977-1231-231', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150002', 'Angel Daligdig Bautista', '(+63) 977-1231-211', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150004', 'Bless Andre Mamuyac Catbagan', '(+63) 977-1211-009', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150005', 'Wendel Mapalo Catbagan', '(+63) 983-4531-231', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150006', 'Zenederick Mamuyac Catbagan', '(+63) 995-1789-200', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150007', 'Vincent Bilog Dacanay', '(+63) 977-4501-231', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150008', 'Gerick De Gracia  De Jesus', '(+63) 977-4501-232', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150009', 'Justine Dave Villanueva Ferrer', '(+63) 977-4501-233', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150011', 'Jhesryl Echica Galvez', '(+63) 977-4501-234', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150012', 'John Denver Ferrer Magdaraog', '(+63) 995-1785-282', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150013', 'Aldrin Dayag Nipa', '(+63) 995-1785-284', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150014', 'Jerico Nipa Nipa', '(+63) 977-4501-240', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150015', 'Daryl Leoncion Sembrano', '(+63) 977-4501-243', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150016', 'Ella Mae Dacanay Acosta', '(+63) 977-4501-247', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150017', 'Princess Nicole Abellera Villanueva', '(+63) 977-4512-311', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150018', 'Helarie Shane Melendres Catbagan', '(+63) 995-1751-232', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150019', 'Marissa Hugo Munar', '(+63) 994-4351-111', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150021', 'Jessa Catbagan Colobong', '(+63) 954-9023-112', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150022', 'Melody Munar Cahuyen', '(+63) 977-1400-723', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150023', 'Rhyza Mae Estacio Ducayag', '(+63) 977-4501-251', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150024', 'Daisy Rose Marquez Esteves', '(+63) 977-4501-253', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150025', 'Rihanna Marie Ridual Marquez', '(+63) 939-9774-503', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150026', 'Angela Nipa Nardo', '(+63) 939-9774-504', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150027', 'Raychelle Mae Verceles Ordoño', '(+63) 995-1785-190', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150028', 'Kim Medina Peralta', '(+63) 977-4121-231', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150029', 'Marnel Garcia Rimas', '(+63) 977-4300-212', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150030', 'April Rose Rimas Salas', '(+63) 997-5323-421', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150033', 'Mark John Villanueva Boado', '(+63) 977-1200-111', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150034', 'Cris Aaron Tavas Daligdig', '(+63) 977-1401-711', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150037', 'Franiel Congayao Niñalga', '(+63) 995-1785-283', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150038', 'Mark Angelo Ridual Padin', '(+63) 987-6654-353', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150039', 'Aldrin Jose Pimentel', '(+63) 954-3443-242', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150042', 'Henry Jr Dacanay Rivera', '(+63) 994-5343-212', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150043', 'Vince Aeron Eslava Rosales', '(+63) 995-1232-131', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150044', 'King Elmer Padin Tabernero', '(+63) 977-4501-244', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150045', 'Reniel Marquez Verceles', '(+63) 995-1785-234', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150046', 'John Lee Parado Viloria', '(+63) 977-4501-245', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150047', 'Karl Chester Verceles Yap', '(+63) 921-3451-231', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150048', 'Jolina Mae Estoque Catbagan', '(+63) 977-4501-248', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150049', 'Rochelle Verceles Catbagan', '(+63) 977-4501-249', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150050', 'Bea Verceles Noces', '(+63) 996-5178-234', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150051', 'Precious Shaira Miles Sabela Padin', '(+63) 939-9774-505', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150052', 'Princess Audrey Gail Romero Padin', '(+63) 939-9774-505', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150053', 'Manilyn Lomibao Parado', '(+63) 995-1786-789', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150054', 'Cyriel Jane Boado Paredes', '(+63) 977-1300-211', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101090150055', 'Alexandra Mae Abarca Quesada', '(+63) 939-9774-506', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093100012', 'John Lloyd Cosare Gracias', '(+63) 921-3213-232', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093100030', 'Jun Onrada Tagura', '(+63) 999-9213-213', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120002', 'Jovan Verceles Advincula', '(+63) 998-3213-657', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120003', 'Vince Lander De Vera Agasen', '(+63) 995-1786-230', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120005', 'Mark Daniel Dumagat Bilog', '(+63) 971-2333-007', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120007', 'Raffy Allen Medina Galera', '(+63) 977-1234-565', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120019', 'Desiree Bilog Cornelia', '(+63) 998-7711-100', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120025', 'Samantha Jane Bilog Fernandez', '(+63) 912-3122-217', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120034', 'Renz Oliver Bilog Fernandez', '(+63) 949-8177-016', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120038', 'John Rejay Agasen Menguillan', '(+63) 997-2341-312', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093120044', 'Van Olrick Neil Soliven Sajol', '(+63) 923-1111-197', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130001', 'Vincent Lester De Vera Agasen', '(+63) 977-1499-777', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130002', 'Franklin Redondo Bilog', '(+63) 977-1499-779', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130008', 'John Dave Agasen Minguillan', '(+63) 977-1499-722', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130011', 'Markm Yvan Soriano Padin', '(+63) 949-8177-025', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130013', 'John Lloyd Dujenia Rivera', '(+63) 977-1499-725', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130014', 'Neville Soliven Sajol', '(+63) 949-8177-028', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130017', 'Geryl Bilog Agasen', '(+63) 977-1499-727', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130024', 'Princess Janah Batalla Bilog', '(+63) 977-1499-730', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093130037', 'Mark Raymund Agasen Cariso', '(+63) 949-7177-010', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140007', 'Cris Lorence De Vera Agasen', '(+63) 995-7892-801', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140010', 'Darwin Gontao Bilog', '(+63) 995-1785-210', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140013', 'Gian Zai Jay Laron Galera', '(+63) 995-7892-809', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140016', 'Christian Jay Laceste Necida', '(+63) 995-7892-814', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140022', 'Natalie Joy Bilog Cojotan', '(+63) 995-7892-818', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140023', 'Nicole Bilog Ducusin', '(+63) 995-7892-819', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140024', 'Mikaella Bilog Fernandez', '(+63) 995-7892-820', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140025', 'Jasmine Thea Zafe Hufalar', '(+63) 995-7892-823', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140030', 'Leah Mae Dacanay Padin', '(+63) 981-2234-002', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093140032', 'Jehanna Mae Gallego Lachica', '(+63) 949-8177-042', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093150007', 'James Bilog Cornelia', '(+63) 995-1785-281', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093150010', 'Mark Lester Cosare Gracias', '(+63) 977-1400-712', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093150011', 'John Paul Mamuyac Hufalar', '(+63) 977-4501-238', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093150014', 'Mhel Kenneth Nitura Olarte', '(+63) 977-4501-241', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093150016', 'Arwin Verceles Rafanan', '(+63) 995-1785-290', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093150017', 'Ronnie Dugenia Rivera', '(+63) 996-1278-654', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093150020', 'Zyren Grace Hufalar Estacio', '(+63) 977-4501-252', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101093160020', 'Ashley Redondo Bilog', '(+63) 949-8177-041', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101094110042', 'Janelle Ramirez Fernandez', '(+63) 977-1400-711', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097100007', 'Angelica Riguer Garcia', '(+63) 912-3089-875', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097100009', 'Sherlyn Mae Marquez Garcia', '(+63) 976-4345-765', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097100021', 'Rochell Verceles Peralta', '(+63) 967-2804-835', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097110005', 'Danebiel Gracias Garcia', '(+63) 949-7177-012', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097110006', 'Lds John Hermoso Garcia', '(+63) 945-3411-222', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097110009', 'Cristylyn Peralta Mamungay', '(+63) 971-2312-310', '11-HUMSS', 'Mr. Jeffrey C. Galera', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097110021', 'Laurence Ridual Peralta', '(+63) 970-5343-412', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097110022', 'Rachelle Navarro Rualo', '(+63) 964-5678-902', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097120004', 'Gadmaniel Garcia Pineda', '(+63) 912-3413-423', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097130005', 'Denmark Refugia Garcia', '(+63) 949-8177-017', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097140007', 'Jovan Riguer Garcia', '(+63) 995-1785-214', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097140008', 'A-jay Peralta Japson', '(+63) 995-7892-812', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097140011', 'Mark Joseph Navarro Marquez', '(+63) 995-1785-218', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097140012', 'Lenard Ridual Peralta', '(+63) 995-1785-221', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097140018', 'Alicia Keys Carbonell Peralta', '(+63) 996-1785-241', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097150001', 'Jero Gracias Garcia', '(+63) 977-4501-235', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097150006', 'Patrick Dumaguin Peralta', '(+63) 977-4501-242', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097150012', 'Merylle Joy Refugia Garcia', '(+63) 982-1312-313', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097150014', 'Janella Mae Acosta Mamuyac', '(+63) 996-7894-118', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101097150018', 'Eunice De Guzman Peralta', '(+63) 997-6120-005', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101100011', 'Rhizia Mae Salas Mamuyac', '(+63) 975-1209-212', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101100016', 'Rica Jane Calongcagong Medina', '(+63) 901-2223-444', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101110010', 'Mark Dom Anthony Buhle Lachica', '(+63) 975-4231-121', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130004', 'Christopher Medina Jucutan', '(+63) 949-8177-019', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130006', 'Dioby Bong Igos Lachica', '(+63) 949-8177-020', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130007', 'Gringo Piamonte Lachica', '(+63) 977-1499-717', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130008', 'Ivan Derk Ballesteros Macalalag', '(+63) 949-8177-021', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130011', 'Raymark Garcia Mamuyac', '(+63) 977-1499-720', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130013', 'Rayvin Jay Calongcagong Medina', '(+63) 977-1499-721', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130020', 'Janmher Mae Gallego Lachica', '(+63) 949-8177-043', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101130021', 'Chriziel Capangpangan Mamuyac', '(+63) 949-8177-044', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101140002', 'John Lloyd Alampas Mamuyac', '(+63) 995-1785-217', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101140006', 'Jerick Balag-ey Orpilla', '(+63) 995-1785-220', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101140024', 'Cherry Joy Lachica Villanueva', '(+63) 981-2234-004', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101150004', 'Jan Edmher Gallego Lachica', '(+63) 987-7894-117', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101150015', 'Chrisha Mae  Padin Acosta', '(+63) 977-4501-246', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101150024', 'Donita Gwen Medina Sapitula', '(+63) 977-4523-132', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('101101150027', 'Stephanie Jane Dacanay Villanueva', '(+63) 939-9774-507', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('101103140041', 'Lorraine Bilog Eslava', '(+63) 996-1785-235', '8-Molave', 'Mr. Jeremy Parado Marquez', 'password', '');
INSERT INTO `tbl_student` VALUES ('101795140126', 'Jhiya Mee Vicedo Dacanay', '(+63) 977-3324-321', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('101913140035', 'Arielle Mae Dela Cruz Medriano', '(+63) 981-2234-001', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('101914130144', 'Rhian Calub Dacumos', '(+63) 949-8177-035', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('102241120018', 'Michaela Joy Gabuyan Salas', '(+63) 941-3212-232', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('102241120084', 'Mj Gabuyan Salas', '(+63) 943-4312-111', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('102288140024', 'John Aldrin Vergara Quitoles', '(+63) 949-8177-027', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('104164100040', 'Mark Lester Insulia Nitura', '(+63) 983-1231-312', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('104164150011', 'Justin Carl Insulia Nitura', '(+63) 995-7892-815', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('104908140182', 'Bryan James Ofiana Caoile', '(+63) 995-7892-803', '8-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('104930100040', 'John Christian Dumaran Dalagan', '(+63) 977-1499-713', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('105144120648', 'Hanz Hermie Melendres Dela Torre', '(+63) 949-7177-011', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('106069150211', 'Jeyzel Dela Peña Daligdig', '(+63) 977-4501-250', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('106465100053', 'Deen Russel Tuazon Rosas', '(+63) 964-1299-876', '12-HUMMS', 'Ms. Charlene Mae G. Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('106731150083', 'Ashley Joy Rivera Martines', '(+63) 954-1390-872', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('108082120088', 'Arjames Gemina Madrilejo', '(+63) 949-7177-015', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('108082130080', 'Kristel Gimena Madrilejo', '(+63) 902-3131-122', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('108533110012', 'Carl Justine Gariguez De Gracia', '(+63) 988-9853-232', '11-GAS', 'Mrs. Catherine F. Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('108533130057', 'Uahana Kriselle Gariguez De Gracia', '(+63) 949-8177-039', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('123456789', 'Albert', '(+63) 917-8942-731', '12-GAS', 'Mr. Patrick', 'password', '');
INSERT INTO `tbl_student` VALUES ('126378120022', 'Reynan Dave Gontao Bilog', '(+63) 977-1499-710', '9-Olive', 'Mr. Frank Quidit Calub Jr', 'password', '');
INSERT INTO `tbl_student` VALUES ('135628150016', 'Sabrina Kae Refuerzo Talania', '(+63) 995-1782-345', '7-Camachile', 'Mrs. Ruth Rivera Maestro', 'password', '');
INSERT INTO `tbl_student` VALUES ('135632060011', 'Jayvie Calub Bulandres', '(+63) 998-7654-423', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('135679120023', 'Mark Vincent Dela Cruz Medriano', '(+63) 995-7892-813', '7-Ipil-Ipil', 'Mrs. Jesusa Dulay Villanueva', 'password', '');
INSERT INTO `tbl_student` VALUES ('136431120791', 'John Manuel Hufalar Soque', '(+63) 956-4534-231', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('136617100049', 'Jason Vergel Parado Alonzo', '(+63) 943-3234-987', '12-GAS', 'Dr. John-John Q. Garcia', 'password', '');
INSERT INTO `tbl_student` VALUES ('136876090415', 'Cielo Beri Marcelo', '(+63) 912-3424-522', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');
INSERT INTO `tbl_student` VALUES ('136891150246', 'Jeff Santillan Alibayan', '(+63) 977-3098-761', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', 'password', '');
INSERT INTO `tbl_student` VALUES ('403825150274', 'Ashley Marie Hufalar Navales', '(+63) 949-8177-046', '9-Kamagong', 'Mrs. Jobelle Picar Rocapor', 'password', '');
INSERT INTO `tbl_student` VALUES ('403825150320', 'Miesha Franchesca Hufalar Navales', '(+63) 976-5321-012', '10-Acacia', 'Mrs. Imelda Garcia Gracias', 'password', '');

-- ----------------------------
-- Table structure for `tbl_studentborrowers`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_studentborrowers`;
CREATE TABLE `tbl_studentborrowers` (
  `Username` varchar(12) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `ContactNo` varchar(255) NOT NULL,
  `GradeSec` varchar(255) NOT NULL,
  `Teacher` varchar(255) NOT NULL,
  `ItemID` int(255) NOT NULL AUTO_INCREMENT,
  `ItemNumber` varchar(255) NOT NULL,
  `ItemType` varchar(255) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `DateBorrowed` varchar(255) NOT NULL,
  `DatetoReturn` varchar(255) NOT NULL,
  PRIMARY KEY (`ItemID`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_studentborrowers
-- ----------------------------
INSERT INTO `tbl_studentborrowers` VALUES ('101090130036', 'Mel Dheon Munar Jucutan', '(+63) 977-1499-716', '9-Olive', 'Mr. Frank Quidit Calub Jr', '43', '00522001', 'Printed', 'Information Technology', '28/10/2022', '31/10/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('101090140013', 'Francis Bryan Villanueva Hidalgo', '(+63) 977-4501-237', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '44', '00522003', 'Printed', 'Information Technology', '28/10/2022', '31/10/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('101090140045', 'Regine Emperador Gepega', '(+63) 939-9774-502', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '45', '30022002', 'Printed', 'Social Science: An Introduction to the Study of Society', '28/10/2022', '31/10/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('100816100072', 'Felix Ramos Medina', '(+63) 977-4501-239', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '46', '1002', 'Non-Printed', 'Globe - World', '15/11/2022', '17/11/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('100845150051', 'Princess Jewel Grace Alas Orejudos', '(+63) 939-9774-505', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '47', '2000', 'Non-Printed', 'Periodic Table', '15/11/2022', '18/11/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('101007150010', 'Ernest Charl Valdez Geneta', '(+63) 977-4501-236', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '48', '2001', 'Non-Printed', 'Periodic Table', '15/11/2022', '16/11/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('101090140013', 'Francis Bryan Villanueva Hidalgo', '(+63) 977-4501-237', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '49', '2002', 'Non-Printed', 'Periodic Table', '15/11/2022', '15/11/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('101090140013', 'Francis Bryan Villanueva Hidalgo', '(+63) 977-4501-237', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '50', '3000', 'Non-Printed', 'Philippine Map', '15/11/2022', '15/11/2022');
INSERT INTO `tbl_studentborrowers` VALUES ('101090140045', 'Regine Emperador Gepega', '(+63) 939-9774-502', '7-Narra', 'Mrs. Tricia Mae Laplana Carbonell', '51', '4000', 'Non-Printed', 'World Map', '15/11/2022', '17/11/2022');

-- ----------------------------
-- Table structure for `tbl_users`
-- ----------------------------
DROP TABLE IF EXISTS `tbl_users`;
CREATE TABLE `tbl_users` (
  `Username` varchar(50) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Usertype` varchar(50) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of tbl_users
-- ----------------------------
INSERT INTO `tbl_users` VALUES ('100809100001', 'Paula Marie Padin Abanes', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('100816100072', 'Felix Ramos Medina', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('100826130014', 'Renz Aldwin Abubo Mamuyac', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('100845150051', 'Princess Jewel Grace Alas Orejudos', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('100919100025', 'Rovelyn Gonzales Ventura', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('100929140032', 'Orlando De Gracia Gapuz III', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('100942110012', 'Argie Piamonte Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('100999100038', 'Danica Dacanay Ventura', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101005120010', 'Angie Lyn Catbagan Mamuyac', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101007130024', 'Adelfa Jucutan Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101007140003', 'Justine Mark Jucutan Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101007150010', 'Ernest Charl Valdez Geneta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101029140013', 'Lorie Peralta Ursua', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101036080135', 'Ryan William Halog Oropilla', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101089110012', 'Melanie Orpilla Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100001', 'Aljean Daligdig Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100002', 'Crisanto Rosete Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100003', 'Jerome Peralta Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100004', 'Mariel Dacanay Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100005', 'Justin Niñalga Baylon', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100006', 'Mark Jurell Leoncion Besin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100007', 'Louiza Rae Rivera Boado', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100008', 'Cylene Joy Carpio Calub', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100010', 'Jovan Hufalar Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100015', 'Julius Grandia Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100016', 'Paul Briane Villanueva Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100017', 'Chardine Jucutan De Gracia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100018', 'Mariane Joy Leoncion De Gracia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100021', 'Alona Medina Emperador', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100022', 'Erna Monzales Emperador', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100023', 'Gio Medina Emperador', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100024', 'Noel Jr Ballesteros Estacio', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100025', 'Stephen Gracias Estacio', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100027', 'John Marc Cagujas Pugal', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100028', 'Karina Joyce Boado Geneta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100030', 'Ira Jayne Garcia Gracias', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100031', 'Jaime Jr Catbagan Jucutan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100035', 'Joana Marie De Gracia Marquez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100036', 'Jasper John Rivera Mendoza', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100037', 'Karylle Padin Montemayor', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100038', 'Joey De Gracia Munar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100039', 'Norshel Cruz Munar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100040', 'Noemi Nipa Nardo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100042', 'Princess Ubalde Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100047', 'Angel Oropilla Ridual', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100049', 'Christine Medina Rimas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100053', 'Mark Ferrer Salas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100054', 'Shaina Parado Sesaldo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100055', 'Benjie Nisperos Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100056', 'Jacquilyn Jampit Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100057', 'Jocelyn Quiroga Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100058', 'John Ismael Montemayor Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090100060', 'Raymel Catbagan Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110001', 'Mark Joseph Casison Abunda', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110003', 'Lhe Anne Dacanay Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110004', 'Philip Angel Acosta Alibayan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110005', 'Tyrone Sean Leoncion Ammalin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110006', 'Reden Parado Aspillaga', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110008', 'Luigi Calub Ballesteros', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110010', 'Charlene Rimas Calub', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110011', 'Syrell Mamuyac Calub', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110012', 'Carl Stephen Pineda Caoile', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110013', 'Roxane Jucutan Castro', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110015', 'Cyrus Niñalga Costales', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110016', 'Mike Bilog Dacanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110018', 'Mark Christian Tavas Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110020', 'Leslie Anne Ducusin Domanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110022', 'Eric Aquino Emperador', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110023', 'Jan Rick Quinones Gallardo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110025', 'Mc Arthur Ridual Hufalar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110026', 'Johary Acosta Jarabe', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110027', 'Chrisha Mae Munar Jucutan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110030', 'Jamaica Garcia Marquez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110031', 'Jonah Mae Leoncion Marquez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110032', 'Kevin Acosta Maynes', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110037', 'Cristine Paras Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110038', 'Daniella Marie Dayag Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110040', 'Alona Boadilla Ocampo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110041', 'Mark Angelo Verceles Ordoño', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110042', 'Menard Ryan Verceles Ordoño', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110043', 'Gabriela Ridual Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110044', 'Kurt Darelle Dagatan Pineda', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110047', 'Joshua Rofert Lumauig Rivera', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110050', 'John Paul Rivera Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090110056', 'John Alfred Parado Viloria', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120001', 'Justine Riguer Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120005', 'Cidrick Verceles Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120006', 'Jeremy Dacanay Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120014', 'Ken Mavericks Leoncion Besin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120018', 'Aron Acosta Jarabe', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120020', 'Shan Jiro Padin Navarro', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120021', 'Fredrich Congayao Niñalga', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120023', 'Ivan Dagatan Pineda', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120026', 'Ace Patrick Padin Tabernero', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120027', 'Regie Niñalga Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120030', 'Jessa Mhee Campos Calub', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120031', 'Maria Cristina Angelica Calub Cayuhen', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120034', 'Grashiela Mae Mamuyac Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120035', 'Rholyn Yares De Gracia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120036', 'Christel Joy Bautista Estacio', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120037', 'Andrea Mae Dacanay Geneta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090120040', 'Claire Nipa Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130001', 'Elner Coronel Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130002', 'Gian Carlo Medina Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130003', 'Angelo Daligdig Bautista', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130004', 'Jovart Campos Calub', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130005', 'Denver Kurt Tulingan Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130006', 'Jereco Estacio Dacanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130007', 'Cedrick Gracias Estacio', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130008', 'Jerome Ballesteros Estacio', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130009', 'Reneboy Carbonell Ferrer', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130010', 'Rhian Acosta Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130011', 'Sherwin Cruz Munar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130012', 'Mark Aaron Ashley Sabela Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130013', 'Mark Jhun Fonseca Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130014', 'James Cesar Boado Paredes', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130016', 'Jiecel Verceles Aspuria', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130020', 'Kylie Mae Catbagan Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130022', 'Danica Joy Bilog Eslava', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130024', 'Christine Emperador Gepega', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130025', 'Kim Acosta Maynes', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130027', 'April Heart Hufalar Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130030', 'Marlon Acosta Catbagan Jr', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130031', 'Ryan Verceles Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130032', 'Manny Bilog Dacanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130033', 'Chris Jared Tavas Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130034', 'Mark James Padin Dulay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130035', 'Benedict Aviles Hufalar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130036', 'Mel Dheon Munar Jucutan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130037', 'Jaylord Diez Leoncion', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130040', 'David Andrie Dayag Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130042', 'Ryan Dave Emperador Rimas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130043', 'Gian Dave Parado Toledo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130044', 'Aldred Jade Estacio Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130045', 'Bea Myquelle Celine Leoncion Ammalin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130047', 'Rica Nemia Grandia Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130051', 'Micah Ella Cacanando Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090130054', 'Eriah Blessy Montemayor Tillay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140002', 'James Ivan Catbagan Boado', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140004', 'Marvin Jr Pineda Caoile', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140005', 'Justine Luke Hufalar Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140006', 'Romel Verceles Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140007', 'Kenneth Cacabelos Dacanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140008', 'Lemuel John Erosa Dacanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140009', 'Justin Catbagan Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140010', 'Rodel Mamuyac Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140011', 'Christian Zane Pobre Dulos', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140012', 'Aldrin Medina Emperador', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140013', 'Francis Bryan Villanueva Hidalgo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140014', 'Russel Andrie Catu Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140016', 'Alexis Emperador Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140017', 'George Jairus Ridual Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140020', 'John Paul Catbagan Ruam', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140021', 'Dranreb Seonne Parado Toledo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140022', 'Jay Mark Ubalde Velasquez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140023', 'Jaspher Hufalar Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140024', 'Jureson Nisperos Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140025', 'Mc James Catbagan Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140027', 'Mark Ridual Hufalar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140028', 'Aicy Belleza Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140029', 'Gherickylle Shine Rivera Cabera', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140031', 'Bea Rimas Calub', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140032', 'Jessica Mae Mamuyac Calub', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140033', 'Divine Tabernero Caoile', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140034', 'Jolan Aquino Casison', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140035', 'Cathlyn Joy Veronica Calub Cayuhen', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140037', 'Jasmine Ninalga Costales', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140038', 'Jenica Shane Leoncion Dela Cruz', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140039', 'Elnoraine Bacalzo Domondon', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140040', 'Joeynah Verceles Dulay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140043', 'Aira Jane Dacanay Geneta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140044', 'Jasmine Caballero Geneta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140045', 'Regine Emperador Gepega', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140046', 'Precious Mae Tanagon Hufalar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140047', 'Lea Ellaine Munar Licudo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140048', 'Kristine Gail Parado Munar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140049', 'Rose Marie Verceles Noces', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140050', 'Gemma May Dacanay Paculan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140051', 'Hazel Anne Gatchalian Parado', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140052', 'Stephanie Munar Ruam', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140053', 'Mary Joy Ferrer Salas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140054', 'Keann Louise Soque', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140055', 'Princess Angela Castro Tadefa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140063', 'Princess Tuazon Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140064', 'Reyna Reyes Dulay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140066', 'Joyce Mae Catbagan Colobong', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090140072', 'John Paul Hufalar Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150001', 'Dave Zandrix De Gracia Anolin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150002', 'Angel Daligdig Bautista', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150004', 'Bless Andre Mamuyac Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150005', 'Wendel Mapalo Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150006', 'Zenederick Mamuyac Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150007', 'Vincent Bilog Dacanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150008', 'Gerick De Gracia  De Jesus', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150009', 'Justine Dave Villanueva Ferrer', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150011', 'Jhesryl Echica Galvez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150012', 'John Denver Ferrer Magdaraog', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150013', 'Aldrin Dayag Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150014', 'Jerico Nipa Nipa', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150015', 'Daryl Leoncion Sembrano', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150016', 'Ella Mae Dacanay Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150017', 'Princess Nicole Abellera Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150018', 'Helarie Shane Melendres Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150019', 'Marissa Hugo Munar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150021', 'Jessa Catbagan Colobong', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150022', 'Melody Munar Cahuyen', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150023', 'Rhyza Mae Estacio Ducayag', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150024', 'Daisy Rose Marquez Esteves', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150025', 'Rihanna Marie Ridual Marquez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150026', 'Angela Nipa Nardo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150027', 'Raychelle Mae Verceles Ordoño', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150028', 'Kim Medina Peralta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150029', 'Marnel Garcia Rimas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150030', 'April Rose Rimas Salas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150033', 'Mark John Villanueva Boado', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150034', 'Cris Aaron Tavas Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150037', 'Franiel Congayao Niñalga', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150038', 'Mark Angelo Ridual Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150039', 'Aldrin Jose Pimentel', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150042', 'Henry Jr Dacanay Rivera', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150043', 'Vince Aeron Eslava Rosales', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150044', 'King Elmer Padin Tabernero', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150045', 'Reniel Marquez Verceles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150046', 'John Lee Parado Viloria', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150047', 'Karl Chester Verceles Yap', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150048', 'Jolina Mae Estoque Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150049', 'Rochelle Verceles Catbagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150050', 'Bea Verceles Noces', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150051', 'Precious Shaira Miles Sabela Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150052', 'Princess Audrey Gail Romero Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150053', 'Manilyn Lomibao Parado', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150054', 'Cyriel Jane Boado Paredes', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101090150055', 'Alexandra Mae Abarca Quesada', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093100012', 'John Lloyd Cosare Gracias', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093100030', 'Jun Onrada Tagura', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120002', 'Jovan Verceles Advincula', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120003', 'Vince Lander De Vera Agasen', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120005', 'Mark Daniel Dumagat Bilog', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120007', 'Raffy Allen Medina Galera', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120019', 'Desiree Bilog Cornelia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120025', 'Samantha Jane Bilog Fernandez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120034', 'Renz Oliver Bilog Fernandez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120038', 'John Rejay Agasen Menguillan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093120044', 'Van Olrick Neil Soliven Sajol', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130001', 'Vincent Lester De Vera Agasen', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130002', 'Franklin Redondo Bilog', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130008', 'John Dave Agasen Minguillan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130011', 'Markm Yvan Soriano Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130013', 'John Lloyd Dujenia Rivera', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130014', 'Neville Soliven Sajol', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130017', 'Geryl Bilog Agasen', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130024', 'Princess Janah Batalla Bilog', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093130037', 'Mark Raymund Agasen Cariso', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140007', 'Cris Lorence De Vera Agasen', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140010', 'Darwin Gontao Bilog', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140013', 'Gian Zai Jay Laron Galera', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140016', 'Christian Jay Laceste Necida', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140022', 'Natalie Joy Bilog Cojotan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140023', 'Nicole Bilog Ducusin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140024', 'Mikaella Bilog Fernandez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140025', 'Jasmine Thea Zafe Hufalar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140030', 'Leah Mae Dacanay Padin', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093140032', 'Jehanna Mae Gallego Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093150007', 'James Bilog Cornelia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093150010', 'Mark Lester Cosare Gracias', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093150011', 'John Paul Mamuyac Hufalar', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093150014', 'Mhel Kenneth Nitura Olarte', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093150016', 'Arwin Verceles Rafanan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093150017', 'Ronnie Dugenia Rivera', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093150020', 'Zyren Grace Hufalar Estacio', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101093160020', 'Ashley Redondo Bilog', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101094110042', 'Janelle Ramirez Fernandez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097100007', 'Angelica Riguer Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097100009', 'Sherlyn Mae Marquez Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097100021', 'Rochell Verceles Peralta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097110005', 'Danebiel Gracias Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097110006', 'Lds John Hermoso Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097110009', 'Cristylyn Peralta Mamungay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097110021', 'Laurence Ridual Peralta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097110022', 'Rachelle Navarro Rualo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097120004', 'Gadmaniel Garcia Pineda', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097130005', 'Denmark Refugia Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097140007', 'Jovan Riguer Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097140008', 'A-jay Peralta Japson', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097140011', 'Mark Joseph Navarro Marquez', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097140012', 'Lenard Ridual Peralta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097140018', 'Alicia Keys Carbonell Peralta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097150001', 'Jero Gracias Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097150006', 'Patrick Dumaguin Peralta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097150012', 'Merylle Joy Refugia Garcia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097150014', 'Janella Mae Acosta Mamuyac', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101097150018', 'Eunice De Guzman Peralta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101100011', 'Rhizia Mae Salas Mamuyac', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101100016', 'Rica Jane Calongcagong Medina', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101110010', 'Mark Dom Anthony Buhle Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130004', 'Christopher Medina Jucutan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130006', 'Dioby Bong Igos Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130007', 'Gringo Piamonte Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130008', 'Ivan Derk Ballesteros Macalalag', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130011', 'Raymark Garcia Mamuyac', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130013', 'Rayvin Jay Calongcagong Medina', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130020', 'Janmher Mae Gallego Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101130021', 'Chriziel Capangpangan Mamuyac', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101140002', 'John Lloyd Alampas Mamuyac', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101140006', 'Jerick Balag-ey Orpilla', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101140024', 'Cherry Joy Lachica Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101150004', 'Jan Edmher Gallego Lachica', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101150015', 'Chrisha Mae  Padin Acosta', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101150024', 'Donita Gwen Medina Sapitula', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101101150027', 'Stephanie Jane Dacanay Villanueva', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101103140041', 'Lorraine Bilog Eslava', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101795140126', 'Jhiya Mee Vicedo Dacanay', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101913140035', 'Arielle Mae Dela Cruz Medriano', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('101914130144', 'Rhian Calub Dacumos', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('102241120018', 'Michaela Joy Gabuyan Salas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('102241120084', 'Mj Gabuyan Salas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('102288140024', 'John Aldrin Vergara Quitoles', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('104164100040', 'Mark Lester Insulia Nitura', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('104164150011', 'Justin Carl Insulia Nitura', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('104908140182', 'Bryan James Ofiana Caoile', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('104930100040', 'John Christian Dumaran Dalagan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('105144120648', 'Hanz Hermie Melendres Dela Torre', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('106069150211', 'Jeyzel Dela Peña Daligdig', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('106465100053', 'Deen Russel Tuazon Rosas', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('106731150083', 'Ashley Joy Rivera Martines', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('108082120088', 'Arjames Gemina Madrilejo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('108082130080', 'Kristel Gimena Madrilejo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('108533110012', 'Carl Justine Gariguez De Gracia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('108533130057', 'Uahana Kriselle Gariguez De Gracia', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('126378120022', 'Reynan Dave Gontao Bilog', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('135628150016', 'Sabrina Kae Refuerzo Talania', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('135632060011', 'Jayvie Calub Bulandres', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('135679120023', 'Mark Vincent Dela Cruz Medriano', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('136431120791', 'John Manuel Hufalar Soque', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('136617100049', 'Jason Vergel Parado Alonzo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('136876090415', 'Cielo Beri Marcelo', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('136891150246', 'Jeff Santillan Alibayan', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('19100298', 'Jessa Mae Cabillo Nitura', 'password', 'Admin');
INSERT INTO `tbl_users` VALUES ('19100911', 'Haries Bening', 'password', 'Admin');
INSERT INTO `tbl_users` VALUES ('19100919', 'Patrick Bilaoen', 'password', 'Admin');
INSERT INTO `tbl_users` VALUES ('19101202', 'Ariane Mariz R. Dulay', 'password', 'Admin');
INSERT INTO `tbl_users` VALUES ('403825150274', 'Ashley Marie Hufalar Navales', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('403825150320', 'Miesha Franchesca Hufalar Navales', 'password', 'Student');
INSERT INTO `tbl_users` VALUES ('7001', 'Dr. Marina Gracias Estoesta', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7002', 'Mrs. Tricia Mae Laplana Carbonell', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7003', 'Mrs. Ruth Rivera Maestro', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7004', 'Mrs. Jesusa Dulay Villanueva', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7005', 'Mr. Jeremy Parado Marquez', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7006', 'Mrs. Jobelle Picar Rocapor', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7007', 'Mr. Frank Quidit Calub Jr', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7008', 'Mrs. Imelda Garcia Gracias', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7009', 'Mrs. Catherine F. Carbonell', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7010', 'Dr. John-John Q. Garcia', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7011', 'Ms. Charlene Mae G. Gracias', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7012', 'Mr. Jeffrey C. Galera', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7020', 'Patrick Grey', 'password', 'Faculty');
INSERT INTO `tbl_users` VALUES ('7030', 'Haries Bening', 'password', 'Faculty');
