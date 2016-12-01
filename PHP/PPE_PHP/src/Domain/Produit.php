<?php

namespace PPE_PHP\Domain;

class Produit 
{
    /**
     * Produit id_produit.
     *
     * @var integer
     */
    private $id_produit;

    /**
     * Produit id_famille.
     *
     * @var integer
     */
    private $id_famille;

    /**
     * Produit nom.
     *
     * @var string
     */

    private $nom;

    /**
     * Produit effets.
     *
     * @var string
     */
    private $effets;

    /**
     * Produit contre_indication.
     *
     * @var string
     */
    private $contre_indication;

    /**
     * Produit interactions_autres_produits.
     *
     * @var string
     */
    private $interactions_autres_produits;
    /**
     * Produit presentation.
     *
     * @var string
     */
    private $presentation;

    /**
     * Produit dosage.
     *
     * @var double
     */
    private $dosage;

    /**
     * Produit prix_HT.
     *
     * @var double
     */
    private $prix_HT;

    /**
     * Produit prix_Echantillon.
     *
     * @var double
     */
    private $prix_Echantillon;

    // id_produit
    public function getIdProduit() {
        return $this->id_produit;
    }

    public function setIdProduit($id_produit) {
        $this->id_produit = $id_produit;
    }

    // id_famille
    public function getIdFamille() {
        return $this->id_famille;
    }

    public function setIdFamille($id_famille) {
        $this->id_famille = $id_famille;
    }

    // nom
    public function getNom() {
        return $this->nom;
    }

    public function setNom($nom) {
        $this->nom = $nom;
    }

    // effets
    public function getEffets() {
        return $this->effets;
    }

    public function setEffets($effets) {
        $this->effets = $effets;
    }

    // contre_indication
    public function getContreIndication() {
        return $this->contre_indication;
    }

    public function setContreIndication($contre_indication) {
        $this->contre_indication = $contre_indication;
    }



    private $contre_indication;
private $interactions_autres_produits;
private $presentation;
private $dosage;
private $prix_HT;
$prix_Echantillon;
}
