<?php

namespace PPE_PHP\DAO;

use PPE_PHP\Domain\Gestionnaire;

class GestionnaireDAO extends DAO
{
    /**
     * Return a list of all gestionnaire, sorted by date (most recent first).
     *
     * @return array A list of all gestionnaire.
     */
    public function findAll() {
        $sql = "select * from gestionnaire";
        $result = $this->getDb()->fetchAll($sql);

        // Convert query result to an array of domain objects
        $gestionnaire = array();
        foreach ($result as $row) {
            $id_gestionnaire = $row['id_gestionnaire'];
            $gestionnaire[$id_gestionnaire] = $this->buildDomainObject($row);
        }
        return $gestionnaire;
    }

    /**
     * Returns an gestionnaire matching the supplied id.
     *
     * @param integer $id The gestionnaire id.
     *
     * @return \MicroCMS\Domain\Gestionnaire|throws an exception if no matching gestionnaire is found
     */
    public function find($id_gestionnaire) {
        $sql = "select * from gestionnaire where id_gestionnaire=?";
        $row = $this->getDb()->fetchAssoc($sql, array($id_gestionnaire));

        if ($row)
            return $this->buildDomainObject($row);
        else
            throw new \Exception("No gestionnaire matching id " . $id_gestionnaire);
    }

    /**
     * Saves an gestionnaire into the database.
     *
     * @param \MicroCMS\Domain\Gestionnaire $gestionnaire The gestionnaire to save
     */
    public function save(Gestionnaire $gestionnaire) {
        $gestionnaireData = array(
            'id_gestionnaire' => $gestionnaire->getIdGestionnaire(),
            'login' => $gestionnaire->getLoginGestionnaire(),
            'mdp' => $gestionnaire->getMdpGestionnaire(),
            );

        if ($gestionnaire->getIdGestionnaire()) {
            // The gestionnaire has already been saved : update it
            $this->getDb()->update('gestionnaire', $gestionnaireData, array('id_gestionnaire' => $gestionnaire->getIdGestionnaire()));
        } else {
            // The gestionnaire has never been saved : insert it
            $this->getDb()->insert('gestionnaire', $gestionnaireData);
            // Get the id of the newly created gestionnaire and set it on the entity.
            $id_gestionnaire = $this->getDb()->lastInsertId();
            $gestionnaire->setIdGestionnaire($id_gestionnaire);
        }
    }

    /**
     * Removes an gestionnaire from the database.
     *
     * @param integer $id_gestionnaire The gestionnaire id.
     */
    public function delete($id_gestionnaire) {
        // Delete the gestionnaire
        $this->getDb()->delete('gestionnaire', array('id_gestionnaire' => $id_gestionnaire));
    }

    /**
     * Creates an gestionnaire object based on a DB row.
     *
     * @param array $row The DB row containing gestionnaire data.
     * @return \MicroCMS\Domain\Gestionnaire
     */
    protected function buildDomainObject($row) {
        $gestionnaire = new Gestionnaire();
        $gestionnaire->setIdGestionnaire($row['id_gestionnaire']);
        $gestionnaire->setLoginGestionnaire($row['login']);
        $gestionnaire->SetMdpGestionnaire($row['mdp']);
        return $gestionnaire;
    }
}
