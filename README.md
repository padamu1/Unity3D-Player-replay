# Unity3D-Player-replay

![ezgif com-gif-maker_(1)](https://user-images.githubusercontent.com/26586104/150170326-124460d4-ac74-4045-ad7b-348ef8bcb787.gif)


### How to play

<br />

#### 1. Start this folder with Unity 3D
#### 2. Click Assets-Scenes-SampleScene
#### 3. Click Play Button on Unity 3D

<br />

### Code description

#### Assets - Source - ReplayWithPosition - PlayerMovement.cs

This code use FixedUpdate() for recording replay.   
If you use replay-record on Update(), delete comments mark below 

```
            }

            //replayPosition.Enqueue(transform.position);
        }
        /*
        else
        {
            replayTimer += Time.deltaTime;
            if (replayPosition.Count == 0)
            {
                replay = false;
                Debug.Log(replayTimer);
            }
            else
            {
                transform.position = replayPosition.Dequeue();
            }
        }
        */
```

#### Assets - Source - ReplayWithPosition - PlayerMovementInput.cs

This code use user input for recording replay.
you can attach this to cube of Samplescene

##### Before

![image](https://user-images.githubusercontent.com/26586104/150167351-ffdb65d9-7b7b-47df-81f4-56e299eadeb7.png)


##### After
![image](https://user-images.githubusercontent.com/26586104/150167508-62801740-78f6-4de8-9f44-233ea3ea29b5.png)

<br />

### Recommend Script is ReplayWithPosition - PlayerMovementInput.cs

also recommend used fixedupdate for recording replay

Because this script Shows a replay similar to the user's play.
