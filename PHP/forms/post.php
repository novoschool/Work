<?php
if ($_POST || $_FILES)
{
    if(key_exists("name", $_FILES["doc"])
        && key_exists("tmp_name", $_FILES["doc"]))
    {
        if (!$_FILES["doc"]["error"])
        {
            echo "I love you, but you are dumb Bitch!";
        }
        else
        {
            move_uploaded_file(
                $_FILES["doc"]["tmp_name"],
                "uploads/" . $_FILES["doc"]["name"]
            );
        }
    }
}