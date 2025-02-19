#version 120
uniform sampler2D texture0;
varying vec2 fragTexCoord;
uniform float opacity;
void main(){
	vec4 c = texture2D(texture0, fragTexCoord);
	float r=c.r;float g=c.g;float b=c.b;
	c.r = float(int(2.0*r*8.0))/16;
	c.g = float(int(2.0*g*8.0))/16;
	c.b = float(int(2.0*b*8.0))/16;
	gl_FragColor = vec4(c.r, c.g, c.b, c.a);
}