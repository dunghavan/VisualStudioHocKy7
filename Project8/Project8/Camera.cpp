#include"Camera.h"

GCamera::GCamera()
{
	viewport.x = 1;
	viewport.y = G_ScreenHeight;
	x = 0;
	y = 0;
	alpha = 0.0f;
	scale.x = 1.0f;
	scale.y = 1.0f;
	xscale = 1.0f;
	xalpha = 0.0f;
	IsFollow = true;
}

void GCamera::SetSizeMap(int _max, int _min)
{
	_maxSize = _max;
	_minSize = _min;
}
D3DXVECTOR2 GCamera::Transform(int x, int y)
{
	D3DXMATRIX matrix;
	D3DXMatrixIdentity(&matrix);
	matrix._22 = -1;
	matrix._41 = -viewport.x;
	matrix._42 = viewport.y;

	D3DXVECTOR3 pos3(x, y, 1);
	D3DXVECTOR4 MatrixResult;
	D3DXVec3Transform(&MatrixResult, &pos3, &matrix);

	D3DXVECTOR2 result = D3DXVECTOR2(MatrixResult.x, MatrixResult.y);
	return result;
}

D3DXVECTOR3 GCamera::CenterSprite(int x, int y)
{
	D3DXVECTOR3 pCenter = D3DXVECTOR3(x / 2, y / 2, 0);
	return pCenter;
}

void GCamera::UpdateCamera()
{
	viewport.x += x;
	viewport.y += y;
}
void GCamera::UpdateCamera(int &w, int &h)
{
	//Tự viết dự vào hướng dẫn của GV LT
}
void GCamera::UpdateCamera(float X, float Y)
{
	if (!IsFollow)
	{
		X = x;
		Y = y;
		viewport.x += X;
		viewport.y += Y;
	}
	else
	{
		viewport.x = X;
		viewport.y = Y;
	}
	this->alpha += xalpha;
	this->scale.x *= xscale;
	this->scale.y *= xscale;
}
GCamera  Camera;