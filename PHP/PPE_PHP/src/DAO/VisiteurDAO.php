<?php

namespace PPE_PHP\DAO;

use PPE_PHP\Domain\Article;

class VisiteurDAO extends DAO
{
    /**
     * Return a list of all vendeurs, sorted by cp.
     *
     * @return array A list of all vendeurs.
     */
    public function findAll() {
        $sql = "select * from visiteur order by cp";
        $result = $this->getDb()->fetchAll($sql);

        // Convert query result to an array of domain objects
        $visiteurs = array();
        foreach ($result as $row) {
            $id_visiteur = $row['id_visiteur'];
            $visiteurs[$id_visiteur] = $this->buildDomainObject($row);
        }
        return $vendeurs;
    }

    /**
     * Returns an vendeurs matching the supplied id.
     *
     * @param integer $id The vendeur id.
     *
     * @return \PPE_PHP\Domain\Article|throws an exception if no matching vendeur is found
     */
    public function find($id_visiteur) {
        $sql = "select * from visiteur where id_visiteur=?";
        $row = $this->getDb()->fetchAssoc($sql, array($id));

        if ($row)
            return $this->buildDomainObject($row);
        else
            throw new \Exception("No vendeur matching id " . $id_visiteur);
    }

    //A REPRENDRE LA PROCHAIN COUR

    /**
     * Saves an article into the database.
     *
     * @param \MicroCMS\Domain\Article $article The article to save
     */
    public function save(Article $article) {
        $articleData = array(
            'art_title' => $article->getTitle(),
            'art_content' => $article->getContent(),
            );

        if ($article->getId()) {
            // The article has already been saved : update it
            $this->getDb()->update('t_article', $articleData, array('art_id' => $article->getId()));
        } else {
            // The article has never been saved : insert it
            $this->getDb()->insert('t_article', $articleData);
            // Get the id of the newly created article and set it on the entity.
            $id = $this->getDb()->lastInsertId();
            $article->setId($id);
        }
    }

    /**
     * Removes an article from the database.
     *
     * @param integer $id The article id.
     */
    public function delete($id) {
        // Delete the article
        $this->getDb()->delete('t_article', array('art_id' => $id));
    }

    /**
     * Creates an Article object based on a DB row.
     *
     * @param array $row The DB row containing Article data.
     * @return \MicroCMS\Domain\Article
     */
    protected function buildDomainObject($row) {
        $article = new Article();
        $article->setId($row['art_id']);
        $article->setTitle($row['art_title']);
        $article->setContent($row['art_content']);
        return $article;
    }
}
