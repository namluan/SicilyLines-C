-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 17 nov. 2023 à 09:10
-- Version du serveur : 10.4.27-MariaDB
-- Version de PHP : 8.2.0

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

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `ID` int(2) NOT NULL,
  `id_traversee` int(2) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `LONGUEUR` double(5,2) DEFAULT NULL,
  `LARGEUR` double(5,2) DEFAULT NULL,
  `VITESSE` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `bateauequipement`
--

CREATE TABLE `bateauequipement` (
  `id_equipement` int(2) NOT NULL,
  `id_bateau` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `capacite`
--

CREATE TABLE `capacite` (
  `ID` int(2) NOT NULL,
  `id_categorie` int(2) NOT NULL,
  `MAX` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `ID` int(2) NOT NULL,
  `id_type` int(2) NOT NULL,
  `NOM` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `ID` int(2) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `PRENOM` char(32) DEFAULT NULL,
  `ADRESSE` char(32) DEFAULT NULL,
  `CP` int(2) DEFAULT NULL,
  `VILLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `disponible`
--

CREATE TABLE `disponible` (
  `ID` int(2) NOT NULL,
  `id_type` char(32) NOT NULL,
  `NBPLACE` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `ID` int(2) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `ID` int(2) NOT NULL,
  `id_secteur` int(2) NOT NULL,
  `DEPART` int(11) DEFAULT NULL,
  `ARRIVER` int(11) DEFAULT NULL,
  `DUREE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`ID`, `id_secteur`, `DEPART`, `ARRIVER`, `DUREE`) VALUES
(2, 2, 1, 1, '43'),
(3, 1, 2, 1, '12'),
(7, 1, 1, 2, '12'),
(9, 2, 1, 2, '321');

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `ID` int(2) NOT NULL,
  `DATEDEBUT` char(32) DEFAULT NULL,
  `DATEFIN` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `ID` int(2) NOT NULL,
  `NOM` char(32) DEFAULT NULL
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
  `ID` int(2) NOT NULL,
  `id_traversee` int(2) NOT NULL,
  `id_client` int(2) NOT NULL,
  `DATERES` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `ID` int(2) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
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
  `ID` int(2) NOT NULL,
  `ID_1` char(32) NOT NULL,
  `id_type` int(2) NOT NULL,
  `TARIF` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `ID` int(2) NOT NULL,
  `DATETRAVERSEE` date DEFAULT NULL,
  `HEURETRAVERSEE` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`ID`, `DATETRAVERSEE`, `HEURETRAVERSEE`) VALUES
(1, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `ID` int(2) NOT NULL,
  `TYPE` char(32) DEFAULT NULL
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
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `equipement`
--
ALTER TABLE `equipement`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `liaison`
--
ALTER TABLE `liaison`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `periode`
--
ALTER TABLE `periode`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `port`
--
ALTER TABLE `port`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `secteur`
--
ALTER TABLE `secteur`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `traversee`
--
ALTER TABLE `traversee`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `type`
--
ALTER TABLE `type`
  MODIFY `ID` int(2) NOT NULL AUTO_INCREMENT;

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
