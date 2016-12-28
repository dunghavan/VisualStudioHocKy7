#ifndef _SCENEMAIN_H_
#define _SCENEMAIN_H_

#include "Game.h"
#include "Ball.h"
#include"GSprite.h"
#include"BackGround.h"
#include"Camera.h"

class SceneMain : public CGame
{
public:
	SceneMain(int _nCmdShow);
	~SceneMain();

protected:
	CBall *ball;
	BackGround * background;
	virtual void RenderFrame(LPDIRECT3DDEVICE9 d3ddv, int t);
	virtual void ProcessInput(LPDIRECT3DDEVICE9 d3ddv, int Delta);
	virtual void LoadResources(LPDIRECT3DDEVICE9 d3ddv);

	virtual void OnKeyDown(int KeyCode);
	virtual void OnKeyUp(int KeyCode);
	LPDIRECT3DSURFACE9 _Surface;
};

#endif