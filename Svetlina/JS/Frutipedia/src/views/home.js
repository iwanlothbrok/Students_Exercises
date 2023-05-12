import { html } from '../../node_modules/lit-html/lit-html.js';

const homeTemplate = () => html`
	<section id="home">
		<h1>Learn more about your favorite fruits</h1>
		<img
			src="./images/logo.png"
			alt="home"
		/>
	</section>
`;

export async function homePage(ctx) {
	ctx.render(homeTemplate());
}
