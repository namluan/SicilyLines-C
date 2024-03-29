-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : ven. 29 mars 2024 à 10:14
-- Version du serveur : 8.0.30
-- Version de PHP : 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mlr4`
--
CREATE DATABASE mlr4;
USE mlr4;

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `ID` int NOT NULL,
  `id_traversee` int NOT NULL,
  `NOM` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `LONGUEUR` double(5,2) DEFAULT NULL,
  `LARGEUR` double(5,2) DEFAULT NULL,
  `VITESSE` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `bateauequipement`
--

CREATE TABLE `bateauequipement` (
  `id_equipement` int NOT NULL,
  `id_bateau` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `capacite`
--

CREATE TABLE `capacite` (
  `ID` int NOT NULL,
  `id_categorie` int NOT NULL,
  `MAX` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `ID` int NOT NULL,
  `id_type` int NOT NULL,
  `NOM` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `ID` int NOT NULL,
  `NOM` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `PRENOM` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ADRESSE` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `CP` int DEFAULT NULL,
  `VILLE` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `disponible`
--

CREATE TABLE `disponible` (
  `ID` int NOT NULL,
  `id_type` char(32) COLLATE utf8mb4_general_ci NOT NULL,
  `NBPLACE` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `ID` int NOT NULL,
  `LIBELLE` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `ID` int NOT NULL,
  `id_secteur` int NOT NULL,
  `DEPART` int DEFAULT NULL,
  `ARRIVER` int DEFAULT NULL,
  `DUREE` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`ID`, `id_secteur`, `DEPART`, `ARRIVER`, `DUREE`) VALUES
(2, 2, 1, 1, '43'),
(7, 1, 1, 2, '12'),
(9, 2, 1, 2, '321'),
(10, 1, 2, 1, '2'),
(11, 1, 1, 2, '245'),
(12, 1, 1, 2, '123'),
(13, 1, 2, 1, '124'),
(16, 2, 2, 1, '124'),
(17, 1, 1, 2, '12'),
(18, 1, 1, 2, '12');

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `ID` int NOT NULL,
  `DATEDEBUT` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `DATEFIN` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `ID` int NOT NULL,
  `NOM` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`ID`, `NOM`) VALUES
(1, 'Paris'),
(2, 'Marseille');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `ID` int NOT NULL,
  `id_traversee` int NOT NULL,
  `id_client` int NOT NULL,
  `DATERES` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `ID` int NOT NULL,
  `LIBELLE` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`ID`, `LIBELLE`) VALUES
(1, 'Morteaux'),
(2, 'Cachan');

-- --------------------------------------------------------

--
-- Structure de la table `tarif`
--

CREATE TABLE `tarif` (
  `ID` int NOT NULL,
  `ID_1` char(32) COLLATE utf8mb4_general_ci NOT NULL,
  `id_type` int NOT NULL,
  `TARIF` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `ID` int NOT NULL,
  `DATETRAVERSEE` date DEFAULT NULL,
  `HEURETRAVERSEE` time DEFAULT NULL,
  `id_liaison` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`ID`, `DATETRAVERSEE`, `HEURETRAVERSEE`, `id_liaison`) VALUES
(1, '2023-11-01', '12:06:12', 10),
(2, '2012-04-02', '15:06:03', 11);

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `ID` int NOT NULL,
  `TYPE` char(32) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `bateau`
--
ALTER TABLE `bateau`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_BATEAU_TRAVERSEE` (`id_traversee`);

--
-- Index pour la table `bateauequipement`
--
ALTER TABLE `bateauequipement`
  ADD PRIMARY KEY (`id_equipement`,`id_bateau`),
  ADD KEY `I_FK_ASSO_7_EQUIPEMENT` (`id_equipement`),
  ADD KEY `I_FK_ASSO_7_BATEAU` (`id_bateau`);

--
-- Index pour la table `capacite`
--
ALTER TABLE `capacite`
  ADD PRIMARY KEY (`ID`,`id_categorie`),
  ADD KEY `I_FK_CAPACITE_BATEAU` (`ID`),
  ADD KEY `I_FK_CAPACITE_CATEGORIE` (`id_categorie`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_CATEGORIE_TYPE` (`id_type`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `disponible`
--
ALTER TABLE `disponible`
  ADD PRIMARY KEY (`ID`,`id_type`),
  ADD KEY `I_FK_DISPONIBLE_TYPE` (`ID`),
  ADD KEY `I_FK_DISPONIBLE_RESERVATION` (`id_type`);

--
-- Index pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_LIAISON_SECTEUR` (`id_secteur`);

--
-- Index pour la table `periode`
--
ALTER TABLE `periode`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `port`
--
ALTER TABLE `port`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `I_FK_RESERVATION_TRAVERSEE` (`id_traversee`),
  ADD KEY `I_FK_RESERVATION_CLIENT` (`id_client`);

--
-- Index pour la table `secteur`
--
ALTER TABLE `secteur`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `tarif`
--
ALTER TABLE `tarif`
  ADD PRIMARY KEY (`ID`,`ID_1`,`id_type`),
  ADD KEY `I_FK_TARIF_LIAISON` (`ID`),
  ADD KEY `I_FK_TARIF_PERIODE` (`ID_1`),
  ADD KEY `I_FK_TARIF_TYPE` (`id_type`);

--
-- Index pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `bateau`
--
ALTER TABLE `bateau`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `equipement`
--
ALTER TABLE `equipement`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `liaison`
--
ALTER TABLE `liaison`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT pour la table `periode`
--
ALTER TABLE `periode`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `port`
--
ALTER TABLE `port`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `secteur`
--
ALTER TABLE `secteur`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `traversee`
--
ALTER TABLE `traversee`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `type`
--
ALTER TABLE `type`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `bateau`
--
ALTER TABLE `bateau`
  ADD CONSTRAINT `FK_BATEAU_TRAVERSEE` FOREIGN KEY (`id_traversee`) REFERENCES `traversee` (`ID`);

--
-- Contraintes pour la table `bateauequipement`
--
ALTER TABLE `bateauequipement`
  ADD CONSTRAINT `FK_ASSO_7_BATEAU` FOREIGN KEY (`id_bateau`) REFERENCES `bateau` (`ID`),
  ADD CONSTRAINT `FK_ASSO_7_EQUIPEMENT` FOREIGN KEY (`id_equipement`) REFERENCES `equipement` (`ID`);

--
-- Contraintes pour la table `capacite`
--
ALTER TABLE `capacite`
  ADD CONSTRAINT `FK_CAPACITE_BATEAU` FOREIGN KEY (`ID`) REFERENCES `bateau` (`ID`),
  ADD CONSTRAINT `FK_CAPACITE_CATEGORIE` FOREIGN KEY (`id_categorie`) REFERENCES `categorie` (`ID`);

--
-- Contraintes pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD CONSTRAINT `FK_CATEGORIE_TYPE` FOREIGN KEY (`id_type`) REFERENCES `type` (`ID`);

--
-- Contraintes pour la table `disponible`
--
ALTER TABLE `disponible`
  ADD CONSTRAINT `FK_DISPONIBLE_TYPE` FOREIGN KEY (`ID`) REFERENCES `type` (`ID`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `FK_LIAISON_SECTEUR` FOREIGN KEY (`id_secteur`) REFERENCES `secteur` (`ID`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `FK_RESERVATION_CLIENT` FOREIGN KEY (`id_client`) REFERENCES `client` (`ID`),
  ADD CONSTRAINT `FK_RESERVATION_TRAVERSEE` FOREIGN KEY (`id_traversee`) REFERENCES `traversee` (`ID`);

--
-- Contraintes pour la table `tarif`
--
ALTER TABLE `tarif`
  ADD CONSTRAINT `FK_TARIF_LIAISON` FOREIGN KEY (`ID`) REFERENCES `liaison` (`ID`),
  ADD CONSTRAINT `FK_TARIF_TYPE` FOREIGN KEY (`id_type`) REFERENCES `type` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
