using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoLoader : MonoBehaviour 
{

    [SerializeField]
    private string relativePath;

	// Use this for initialization
    void Start()
    {
        VideoPlayer videoplayer = GetComponent<VideoPlayer>();

        videoplayer.source = VideoSource.Url;
        videoplayer.url = Application.streamingAssetsPath + "/" + relativePath;
        videoplayer.isLooping = true;

        // 読込完了時のコールバック
        videoplayer.prepareCompleted += PrepareCompleted;
        videoplayer.Prepare();

    }
    void PrepareCompleted(VideoPlayer vp)
    {
        vp.prepareCompleted -= PrepareCompleted;
        vp.Play();
	}

    public void VideoPlayerControl()
    {
        VideoPlayer videoplayer = GetComponent<VideoPlayer>();

        if(!videoplayer.isPlaying) {
            videoplayer.Play();
        } else {
            videoplayer.Pause();
        }
    }

}
