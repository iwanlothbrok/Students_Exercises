import { render, screen, cleanup } from '@testing-library/react'
import Test from '../components/Test';

// here is how you clean the rendering 
afterEach(() => {
    // invoce the cleanup
    cleanup();
})

//01 initial custom
// test('should render test component', () => {
//     render(<Test />);

//     const testElement = screen.getByTestId('test-1');

//     expect(testElement).toBeInTheDocument();
//     expect(testElement).toHaveTextContent('Hello World');

// })





//02 with props 
test('matches snapshoot', () => {

    const test = { id: 1, title: 'Test Props' }

    render(<Test test={test} />)

    const testEl = screen.getByTestId('test-1');
    expect(testEl).toBeInTheDocument();
    expect(testEl).toHaveTextContent('Test Props');
    expect(testEl).not.toContainHTML('<h1>')

})