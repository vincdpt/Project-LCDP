<?php

namespace PPE_PHP\Domain;

use Symfony\Component\Security\Core\User\UserInterface;

class Gestionnaire
{
    /**
     * Gestionnaire id_gestionnaire.
     *
     * @var integer
     */
    private $id_gestionnaire;

    /**
     * Gestionnaire login.
     *
     * @var integer
     */
    private $login;

    /**
     * Gestionnaire mdp.
     *
     * @var integer
     */
    private $mdp;


    // id_gestionnaire
    public function getIdGestionnaire() {
        return $this->id_gestionnaire;
    }

    public function setIdGestionnaire($id_gestionnaire) {
        $this->id_gestionnaire = $id_gestionnaire;
    }

    // login
    public function getLoginGestionnaire() {
        return $this->login;
    }

    public function setLoginGestionnaire($login) {
        $this->login = $login;
    }

    // mdp
    public function getMdpGestionnaire() {
        return $this->mdp;
    }

    public function SetMdpGestionnaire($mdp) {
        $this->mdp = $mdp;
    }


}
