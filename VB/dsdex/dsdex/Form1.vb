Public Class dsdex
    Private Sub button_anri_Click(sender As Object, e As EventArgs) Handles button_anri.Click
        display_photos.Image = bkg_storage_anr.Image
        bio_origin.Text = "Appears only in Dark Souls III"
        bio_lore_p1.Text = "Anri of Astora
                           is one of the few children who escaped the grasp of Aldrich, the Man-Eater in his Cathedral of the Deep."
        bio_lore_p2.Text = "Anri's gender is based on the player's, being male if the player is female,
                            and female if the player is male. Anri plays a key part in obtaining the 'Lord of Hollows' ending."
        bio_dropsitems.Text = "Drops 'Anri's Straight Sword' if killed before his/her quest ends"
        bio_soulsyield.Text = "Yields 1000 souls upon death"
    End Sub
    Private Sub button_horace_Click(sender As Object, e As EventArgs) Handles button_horace.Click
        display_photos.Image = bkg_storage_hor.Image
        bio_origin.Text = "Appears only in Dark Souls III"
        bio_lore_p1.Text = "Horace, otherwise known as Horace the Hushed, is the traveling companion
                            of Anri of Astora. He cannot speak due to his tongue having been
                            cut out of his mouth."
        bio_lore_p2.Text = "When the player enters the Catacombs of Carthus, he will no longer be with Anri;
                            he was supposedly seperated from Anri when they fell into a trap. Advancing the quest
                            will make Horace appear in a dead-end cave below the Catacombs in the Smouldering
                            Lake. He will have hollowed, and attacks the player upon approaching him."
        bio_dropsitems.Text = "Drops 'Llewellyn Shield'"
        bio_soulsyield.Text = "Yields 1200 souls upon death"
    End Sub
    Private Sub button_bighat_Click(sender As Object, e As EventArgs) Handles button_bighat.Click
        display_photos.Image = bkg_storage_big.Image
        bio_origin.Text = "Appears only in Dark Souls I, but referenced elsewhere"
        bio_lore_p1.Text = "Big Hat Logan is found trapped in a cage in Sen's Fortress, behind a wall
                           that can only be destroyed by manipulating the boulder trap found higher in the
                           Fortress."
        bio_lore_p2.Text = "Eventually, Logan will find his way to the Grand Archives, where he discovers the
                           crystal sorceries of Seath the Scaleless. Driven mad by their knowledge, he disrobes himself
                           and attacks the player."
        bio_dropsitems.Text = "Drops nothing if killed immediately in Sen's Fortress. Drops his signature big hat if
                              killed elsewhere. Also drops 'Tin Crystallization Catalyst' and the spell 
                              'White Dragon Breath'"
        bio_soulsyield.Text = "Yields 719 souls upon death"
    End Sub
    Private Sub button_karla_Click(sender As Object, e As EventArgs) Handles button_karla.Click
        display_photos.Image = bkg_storage_kar.Image
        bio_origin.Text = "Appears only in Dark Souls III, but is a reference to the character Yuria in Demon's Souls"
        bio_lore_p1.Text = "Presumably the daughter of Alva the Explorer and Zullie the Witch. She is found imprisoned
                           in a cell within Irithyll Dungeon."
        bio_lore_p2.Text = "Able to teach dark sorcery to the player, she may also accept pyromancy and dark
                           miracle tomes."
        bio_dropsitems.Text = "Drops 'Karla's Ashes' upon death, as with most other characters."
        bio_soulsyield.Text = "Yields 1000 souls upon death"
    End Sub
    Private Sub button_elfriede_Click(sender As Object, e As EventArgs) Handles button_elfriede.Click
        display_photos.Image = bkg_storage_elf.Image
        bio_origin.Text = "Appears only in Dark Souls III. Is one of few to be both an NPC and a boss."
        bio_lore_p1.Text = "Elfriede, otherwise known as Friede or Sister Friede, is one of three founding
                           sisters of the Sable Church. She was eventually banished to the Painting of
                           Ariandel, and came to be the companion of its painter, who also dwells within his
                           creation."
        bio_lore_p2.Text = "Sister Friede guards the entrance to the chamber Ariandel dwells in, exsanguinating
                           himself to appease the flame that dwells within the golden vessel he guards. Serving
                           Friede is a knight, Sir Vilhelm, who wields a sword imbued with her black flame -
                           blackflame is the flames of humanity, and bear no shadow."
        bio_dropsitems.Text = "(Phase 2) Titanite Slab
                              (Boss) Soul of Sister Friede"
        bio_soulsyield.Text = "(NPC) Vanishes. No souls yielded.
                              (Boss) Yields 54,000 souls."
    End Sub
End Class
