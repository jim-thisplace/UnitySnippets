	int delay = 0;

	void QueuePlayerTween (float x, float y, float z, int duration, string easeType = "linear")
	{
		iTween.MoveTo (gameObject, iTween.Hash (
			"x", x,
			"y", y,
			"z", z,
			"easeType", easeType,
			"loopType", "none",
			"time", duration,
			"delay", delay
		));

		delay += duration;
	}

	bool hasPlayerClicked = false;

	void MovePlayerTowardsGodRay ()
	{
		QueuePlayerTween (19.9f, 2.0f, 0.5f, 8);
		QueuePlayerTween (-1.5f, 2.0f, 0.8f, 7);
		QueuePlayerTween (-11.5f, 2.0f, 2.5f, 5);
		QueuePlayerTween (-20.1f, 2.0f, -0.2f, 4);

		// Entering the GodRay
		QueuePlayerTween (-20.2f, 2.0f, -12.0f, 10);
		QueuePlayerTween (-20.2f, 120.0f, -12.0f, 6, "easeInQuad");
	}