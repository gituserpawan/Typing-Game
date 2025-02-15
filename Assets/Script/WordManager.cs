using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    public Point_manager PointManager;
    public List<Word> words = new List<Word>();
    public Word ActiveWord;
    private bool hasActiveWord;
    public WordSpawner wordSpawner;

    [Header("Bullet Settings")]
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;

    private bool canShoot = true;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWords(), wordSpawner.SpawnWord());
        Debug.Log(word.word);
        words.Add(word);
    }

    private void Update()
    {
        if (Input.anyKeyDown && letterKey())
        {
            if (canShoot)
            {
                Shoot();
                canShoot = false;
                StartCoroutine(ResetShootCooldown());
            }
        }
    }

    private IEnumerator ResetShootCooldown()
    {
        yield return new WaitForSeconds(0.2f); // Short delay between shots
        canShoot = true;
    }

    void Shoot()
    {
        if (firePoint == null || bulletPrefab == null)
        {
            Debug.LogWarning("FirePoint or BulletPrefab is not assigned!");
            return;
        }

        if (ActiveWord != null && ActiveWord.wordObj != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            Vector3 direction = (ActiveWord.wordObj.transform.position - firePoint.position).normalized;

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = direction * bulletForce;
            }

            if (SoundManager.instance != null)
            {
                SoundManager.instance.PlaySound(audioClip);
            }

            Destroy(bullet, 1f);
        }
    }

    bool letterKey()
    {
        foreach (char c in Input.inputString)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
        }
        return false;
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (ActiveWord.GetNextLetter() == letter)
            {
                ActiveWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    ActiveWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && ActiveWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(ActiveWord);
            ActiveWord = null;
            PointManager.AddPoints(1);
        }
    }
}
