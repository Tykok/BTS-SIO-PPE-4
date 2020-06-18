-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 20 mai 2019 à 19:29
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ms2r_app`
--

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `Login` varchar(50) COLLATE utf8_bin NOT NULL,
  `MDP` varchar(50) COLLATE utf8_bin NOT NULL,
  `NomA` varchar(50) COLLATE utf8_bin NOT NULL,
  `PrenomA` varchar(50) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`Login`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`Login`, `MDP`, `NomA`, `PrenomA`) VALUES
('ygmQhor3Z1JjFAZwKNvRmg==', 'kQlpKaQpkU936nOCRI0jDA==', 'Kévin', 'Champagnat'),
('jEagzmLyve0=', 'jEagzmLyve0=', 'test', 'test'),
('kh8MMLOCaG7HhymbmM6GSw==', 'kQlpKaQpkU936nOCRI0jDA==', 'Sylvie', 'Kosmalski');

-- --------------------------------------------------------

--
-- Structure de la table `logiciel`
--

DROP TABLE IF EXISTS `logiciel`;
CREATE TABLE IF NOT EXISTS `logiciel` (
  `CodeLogi` int(11) NOT NULL AUTO_INCREMENT,
  `LibLogi` varchar(150) CHARACTER SET latin1 NOT NULL,
  `NumLicenceLogi` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `NbrUserLogi` int(11) DEFAULT NULL,
  `DateAchatLog` date DEFAULT NULL,
  PRIMARY KEY (`CodeLogi`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `logiciel`
--

INSERT INTO `logiciel` (`CodeLogi`, `LibLogi`, `NumLicenceLogi`, `NbrUserLogi`, `DateAchatLog`) VALUES
(1, 'Windows 10 Professionel', 'NZXT-NTM8-69SX-BYTE', 26, '2019-01-23'),
(2, 'Windows 7 Professionel', 'UI06-TYKO-D7R5-AHOK', 25, '2019-01-23'),
(3, 'Microsoft Office', 'MAC1-C170-ASTA-0007', 10, '2019-01-23'),
(4, 'CCleaner Pro', 'OHLA-NTM8-69SX-BYTE', 100, '2019-05-31'),
(5, 'Visual Studio 2017', 'UI06-TYKO-D7R5-AHOK', 0, '2019-05-20'),
(6, 'Netflix', 'UI06-TYKO-D7R5-AHOK', 4, '2019-05-20'),
(7, 'PDF Creator', 'UI06-TYKO-D7R5-AHOK', 150, '2019-05-20'),
(8, 'FileZilla', 'UI06-TYKO-D7R5-AHOK', 350, '2019-05-20'),
(9, 'NotePad ++', 'UI06-TYKO-D7R5-AHOK', 350, '2019-05-20'),
(10, 'Visual Studio Code', 'UI06-TYKO-D7R5-AHOK', 0, '2019-05-20');

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

DROP TABLE IF EXISTS `materiel`;
CREATE TABLE IF NOT EXISTS `materiel` (
  `CodeMat` int(11) NOT NULL AUTO_INCREMENT,
  `LibMat` varchar(100) CHARACTER SET latin1 NOT NULL,
  `PxMat` int(11) NOT NULL,
  `GarantieMat` date DEFAULT NULL,
  `DescripMat` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  `MicroPro` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `Ram` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `DisqueD` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `TailleEcran` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `ResolutionEcran` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `Technologie` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `TypeMat` varchar(15) CHARACTER SET latin1 DEFAULT NULL,
  `NumService` int(11) DEFAULT NULL,
  PRIMARY KEY (`CodeMat`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`CodeMat`, `LibMat`, `PxMat`, `GarantieMat`, `DescripMat`, `MicroPro`, `Ram`, `DisqueD`, `TailleEcran`, `ResolutionEcran`, `Technologie`, `TypeMat`, `NumService`) VALUES
(1, 'ASUS', 5000, '2020-04-23', 'Ordinateur très performant ', 'Intel Core I9 ', '64GB', '10To', NULL, NULL, NULL, 'PC', 1),
(2, 'ACER', 2000, '2020-04-23', 'Ordinateur performant ', 'Intel Core I5 ', '16GB', '1To', NULL, NULL, NULL, 'PC', 1),
(3, 'TOSHIBA', 3500, '2020-04-23', 'Ordinateur performant ', 'Intel Core I7 ', '32GB', '3To', NULL, NULL, NULL, 'PC', 1),
(4, 'Fujitsu', 2500, '2020-04-23', 'Ordinateur mileu de gamme ', 'Intel Core I3 ', '8GB', '500GB', NULL, NULL, NULL, 'PC', 1),
(5, 'Alienware', 4500, '2020-04-23', 'Ordinateur très performant ', 'Intel Core I9 ', '128GB', '15To', NULL, NULL, NULL, 'PC', 2),
(6, 'Macbook', 6000, '2020-04-23', 'Ordinateur satisfaisant ', 'Intel Core I7 ', '16GB', '1To', NULL, NULL, NULL, 'PC', 2),
(7, 'Ipad', 500, '2019-05-31', 'Matériel de qualité', NULL, '8Go', '500Go', '480P', NULL, NULL, 'Tablette', NULL),
(8, 'Samsung TV', 560, '2019-05-20', 'Télé pour le divertissement lors des pauses', NULL, NULL, NULL, '1000', '960P', 'Samsung technology 2.0', 'Ecran', NULL),
(9, 'Ipad Mini', 500, '2019-05-20', 'Utile et pratique', NULL, '8Go', '250Go', '128P', NULL, NULL, 'Tablette', NULL),
(10, 'Tablette Samsung', 500, '2019-05-20', 'Tablette très utile pour le matériel Android', NULL, '8Go', '250Go', '128P', NULL, NULL, 'Tablette', 4),
(11, 'Samsung a6', 200, '2019-05-20', 'Matériel très utile pour la compatibilté avec d\'autres matériels', NULL, '8Go', '250Go', '128P', NULL, NULL, 'Tablette', 4),
(12, 'Samsung s3', 600, '2019-05-20', 'Matériel très utile pour la compatibilté avec d\'autres matériels', NULL, '8Go', '250Go', '128P', NULL, NULL, 'Tablette', NULL),
(13, 'Smart TV', 200, '2019-05-20', 'Matériel pour les essais de présentations', NULL, NULL, NULL, '1000', '4K', 'Samsung', 'Ecran', NULL),
(14, 'LED Samsung', 300, '2019-05-20', 'Pour les présentation officiel', NULL, NULL, NULL, '1000', '4K', 'Samsung', 'Ecran', 4),
(15, 'ASUS', 5000, '2020-04-23', 'Ordinateur très performant ', 'Intel Core I9 ', '64GB', '10To', NULL, NULL, NULL, 'PC', 4),
(16, 'ACER', 2000, '2020-04-23', 'Ordinateur performant ', 'Intel Core I5 ', '16GB', '1To', NULL, NULL, NULL, 'PC', 4),
(17, 'TOSHIBA', 3500, '2020-04-23', 'Ordinateur performant ', 'Intel Core I7 ', '32GB', '3To', NULL, NULL, NULL, 'PC', 4),
(18, 'Fujitsu', 2500, '2020-04-23', 'Ordinateur mileu de gamme ', 'Intel Core I3 ', '8GB', '500GB', NULL, NULL, NULL, 'PC', 4),
(19, 'Alienware', 4500, '2020-04-23', 'Ordinateur très performant ', 'Intel Core I9 ', '128GB', '15To', NULL, NULL, NULL, 'PC', 4),
(20, 'Macbook', 6000, '2020-04-23', 'Ordinateur satisfaisant ', 'Intel Core I7 ', '16GB', '1To', NULL, NULL, NULL, 'PC', 4);

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `NumServ` int(11) NOT NULL AUTO_INCREMENT,
  `NomServ` varchar(50) CHARACTER SET latin1 NOT NULL,
  `DescripServ` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`NumServ`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`NumServ`, `NomServ`, `DescripServ`) VALUES
(1, 'Comptabilité 1', 'Service de gestion des factures'),
(2, 'Ressource Humaine 1', 'Service de gestion des employés'),
(3, 'Gestion de la MS2R', 'Service regroupant les cadres gérant la MS2R'),
(4, 'Service Informatique', 'Informaticien de la MS2R');

-- --------------------------------------------------------

--
-- Structure de la table `service_has_logiciel`
--

DROP TABLE IF EXISTS `service_has_logiciel`;
CREATE TABLE IF NOT EXISTS `service_has_logiciel` (
  `SERVICE_NumServ` int(11) NOT NULL,
  `LOGICIEL_CodeLogi` int(11) NOT NULL,
  `Utilisateurs` int(11) NOT NULL,
  PRIMARY KEY (`SERVICE_NumServ`,`LOGICIEL_CodeLogi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `service_has_logiciel`
--

INSERT INTO `service_has_logiciel` (`SERVICE_NumServ`, `LOGICIEL_CodeLogi`, `Utilisateurs`) VALUES
(1, 3, 10),
(2, 1, 12),
(3, 3, 20),
(4, 1, 50),
(4, 5, 50),
(4, 8, 50),
(4, 9, 50),
(4, 10, 50);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
