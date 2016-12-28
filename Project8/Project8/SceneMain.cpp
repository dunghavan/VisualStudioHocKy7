
#include "SceneMain.h"
#include<string>
#define BALL_IMAGE_FILE "ball.bmp"
#define BALL_WIDTH 25
#define BALL_HEIGHT 25

SceneMain::SceneMain(int _nCmdShow) : CGame(_nCmdShow)
{
	
}
void SceneMain::RenderFrame(LPDIRECT3DDEVICE9 d3ddv, int t)
{
	d3ddv->ColorFill(G_BackBuffer, NULL, D3DCOLOR_XRGB(255, 255, 255));
	//ball->Next(t, G_ScreenWidth, G_ScreenHeight);

	//RECT rect;
	//rect.left = (long)ball->x;
	//rect.top = (long)ball->y;
	//rect.right = rect.left + BALL_WIDTH;
	//rect.bottom = rect.top + BALL_HEIGHT;

	//// Draw the surface onto the back buffer
	//d3ddv->StretchRect(
	//	_Surface,			// from 
	//	NULL,				// which portion?
	//	G_BackBuffer,		// to 
	//	&rect,				// which portion?
	//	D3DTEXF_NONE);
	

	G_SpriteHandler->Begin(D3DXSPRITE_ALPHABLEND);
	
	D3DXMATRIX mt;
	D3DXVECTOR2 center(G_ScreenWidth / 2, G_ScreenHeight / 2);
	D3DXMatrixTransformation2D(&mt, &center, 0.0f, &Camera.scale, &center, Camera.alpha, NULL);
	G_SpriteHandler->SetTransform(&mt);
	/*Logger::getInstance()->write_text_to_log_file(std::to_string(ball->GetWidth()));
	Logger::getInstance()->write_text_to_log_file(std::to_string(ball->GetHeight()));*/
	background->Draw();
	ball->Draw();
	G_SpriteHandler->End();
	
	ball->Update(t);
	Camera.UpdateCamera(ball->GetX()-(G_ScreenWidth-ball->GetWidth())/2,ball->GetY()+(G_ScreenHeight-ball->GetHeight())/2);

}

void SceneMain::ProcessInput(LPDIRECT3DDEVICE9 d3ddv, int Delta)
{	
	if (IsKeyDown(DIK_D)) Camera.x = 5;
	else if (IsKeyDown(DIK_A)) Camera.x = -5;
	else if (IsKeyDown(DIK_W)) Camera.y = 5;
	else if (IsKeyDown(DIK_S)) Camera.y = -5;
	else
	{
		Camera.x = 0;
		Camera.y = 0;
	}

	if (IsKeyDown(DIK_U)) Camera.xalpha = 3.14/5;
	else if (IsKeyDown(DIK_I)) Camera.xalpha = -3.14/5;
	else
	{
		Camera.xalpha = 0;
		Camera.xalpha = 0;
	}
	
	if (IsKeyDown(DIK_J)) Camera.xscale = 1.1;
	else if (IsKeyDown(DIK_K)) Camera.xscale = (float)1/(1.1);
	else
	{
		Camera.xscale = 1;
		Camera.xscale = 1;
	}
}

void SceneMain::LoadResources(LPDIRECT3DDEVICE9 d3ddv)
{
	// Create a small off-screen surface (will fill it contain in GameRun)
	d3ddv->CreateOffscreenPlainSurface(
		BALL_WIDTH,				// width 				
		BALL_HEIGHT,			// height
		D3DFMT_X8R8G8B8,		// format
		D3DPOOL_DEFAULT,		// where? (VRAM or RAM)
		&_Surface,
		NULL);

	// Load ball image
	int res = D3DXLoadSurfaceFromFile(
		_Surface, 		// surface
		NULL,			// destination palette	
		NULL,			// destination rectangle 
		BALL_IMAGE_FILE,
		NULL,			// source rectangle
		D3DX_DEFAULT, 	// filter image
		D3DCOLOR_XRGB(0, 0, 0),				// transparency (0 = none)
		NULL);			// reserved
	int x = G_ScreenWidth/2 ;
	int y = G_ScreenHeight/2 ;
	float vx = 0;
	float vy = 0;
	ball = new CBall(x, y, vx, vy);
	background = new BackGround(0, G_ScreenHeight);
	/*Camera = new GCamera();*/
	if (res != D3D_OK)
	{

	}
	srand((unsigned)time(NULL));
}

void SceneMain::OnKeyDown(int KeyCode)
{
	switch (KeyCode)
	{
	case DIK_RIGHT:
		ball->SetVx(0.5);
		break;
	case DIK_LEFT:
		ball->SetVx(-0.5);
		break;
	case DIK_UP:
		ball->SetVy(0.5);
		break;
	case DIK_DOWN:
		ball->SetVy(-0.5);
		break;
	case DIK_SPACE:
		Camera.IsFollow = !Camera.IsFollow;
	}
}
void SceneMain::OnKeyUp(int KeyCode)
{
	switch (KeyCode)
	{
	case DIK_RIGHT:
		ball->SetVx(0);
		break;
	case DIK_LEFT:
		ball->SetVx(0);
		break;
	case DIK_UP:
		ball->SetVy(0);
		break;
	case DIK_DOWN:
		ball->SetVy(0);
	
	}
}
SceneMain::~SceneMain(void)
{
	if (ball != NULL)
		delete ball;
	if (background != NULL)
		delete background;
	/*if (Camera != NULL)
		delete Camera;*/
}
